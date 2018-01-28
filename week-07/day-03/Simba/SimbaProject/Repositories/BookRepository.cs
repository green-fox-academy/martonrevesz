using SimbaProject.Entities;
using SimbaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Repositories
{
    public class BookRepository
    {
        public BookRepository(LibraryContext libraryContext)
        {
            LibraryContext = libraryContext;
        }

        public LibraryContext LibraryContext { get; set; }


        public void UpdateBook(Book inputBook, int id)
        {
            var book = GetSingleBook(id);
            book.Title = inputBook.Title;
            book.TotalCopies = inputBook.TotalCopies;
            LibraryContext.SaveChanges();
        }

        public void RemoveBook(int id)
        {
            var book = GetSingleBook(id);
            LibraryContext.Remove(book);
            LibraryContext.SaveChanges();
        }

        public void Add(Book book)
        {
            LibraryContext.Books.Add(book);
            LibraryContext.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            return LibraryContext.Books.ToList();
        }

        public Book GetSingleBook(int id)
        {
            return LibraryContext.Books.FirstOrDefault(x => x.BookId == id);
        }
    }
}
