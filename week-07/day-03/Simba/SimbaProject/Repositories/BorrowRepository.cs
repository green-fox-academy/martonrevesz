using System;
using SimbaProject.Entities;
using SimbaProject.Models;
using System.Linq;

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

            book.BookReaders.Remove(bookReader);
            reader.BooksReaders.Remove(bookReader);
            ReaderRepository.LibraryContext.SaveChanges();
            book.BorrowedCopies--;
            reader.CurrentBorrow--;
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
            LibraryContext.SaveChanges();
            book.BorrowedCopies++;
            reader.CurrentBorrow++;
        }

    }
}
