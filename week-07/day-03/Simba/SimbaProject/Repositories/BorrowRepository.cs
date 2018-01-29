using SimbaProject.Entities;
using SimbaProject.Models;

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

        public void Borrow(int bookId)
        {
            var book = BookRepository.GetSingleBook(bookId);
            var reader = ReaderRepository.GetSingleReader(ReaderRepository.CurrentId);
            var bookreader = new BookReader() { Book = book, Reader = reader };
            book.BookReaders.Add(bookreader);
            reader.BooksReaders.Add(bookreader);
            LibraryContext.SaveChanges();


        }

    }
}
