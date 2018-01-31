using System;
using SimbaProject.Entities;
using SimbaProject.Models;
using System.Linq;
using System.Collections.Generic;

namespace SimbaProject.Repositories
{
    public class BorrowRepository
    {
        public BorrowRepository(BookRepository bookRepository, ReaderRepository readerRepository, LibraryContext libraryContext)
        {
            BookRepository = bookRepository;
            ReaderRepository = readerRepository;
            LibraryContext = libraryContext;
        }

        public BookRepository BookRepository { get; set; }
        public ReaderRepository ReaderRepository { get; set; }
        public LibraryContext LibraryContext { get; set; }

        public void Back(int bookId)
        {
            var book = BookRepository.GetSingleBook(bookId);
            var reader = ReaderRepository.GetSingleReader(ReaderRepository.CurrentId);
            ReaderRepository.LibraryContext.Entry(book)
                .Collection(b => b.BookReaders)
                .Load();
            ReaderRepository.LibraryContext.Entry(reader)
                .Collection(b => b.BooksReaders)
                .Load();
            var bookReader = book.BookReaders.FirstOrDefault(x => x.Book == book && x.Reader == reader);
            if (bookReader.DueTime.CompareTo(DateTime.Now) < 0)
            {
                reader.Fine += 10;
            }
            book.BookReaders.Remove(bookReader);
            reader.BooksReaders.Remove(bookReader);
            book.BorrowedCopies--;
            reader.CurrentBorrow--;
            ReaderRepository.LibraryContext.SaveChanges();
        }

        public IList<Book> GetBooksForReader(int currentId)
        {
            var reader = ReaderRepository.GetSingleReader(ReaderRepository.CurrentId);
            ReaderRepository.LibraryContext.Entry(reader)
                .Collection(b => b.BooksReaders)
                .Load();
            List<BookReader> brList = reader.BooksReaders.Where(br => br.ReaderId == currentId).ToList();
            return BookRepository.GetBooks()
                .Where(b => (b.BookReaders.ToList()
                    .Intersect(brList)
                    .ToList().Count != 0))
                    .ToList();
        }

        public void Borrow(int bookId)
        {
            var book = BookRepository.GetSingleBook(bookId);
            var reader = ReaderRepository.GetSingleReader(ReaderRepository.CurrentId);
            if(reader.CurrentBorrow >= Reader.totalBorrow || book.BorrowedCopies >= book.TotalCopies)
                return;
            var bookreader = new BookReader() { Book = book, Reader = reader };
            book.BookReaders.Add(bookreader);
            reader.BooksReaders.Add(bookreader);
            book.BorrowedCopies++;
            reader.CurrentBorrow++;
            LibraryContext.SaveChanges();

        }

    }
}
