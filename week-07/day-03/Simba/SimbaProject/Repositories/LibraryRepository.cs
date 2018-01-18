using SimbaProject.Entities;
using SimbaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Repositories
{
    public class LibraryRepository
    {
        public int CurrentId { get; set; }

        public LibraryRepository(LibraryContext libraryContext)
        {
            LibraryContext = libraryContext;
        }

        public LibraryContext LibraryContext { get; set; }

        public List<Reader> GetReaders()
        {
            return LibraryContext.Readers.ToList();
        }

        public Reader GetSingleReader(int id)
        {
            return LibraryContext.Readers.FirstOrDefault(x => x.ReaderId == id);
        }

        public List<Book> GetBooks()
        {
            return LibraryContext.Books.ToList();
        }

        internal Book GetSingleBook(int id)
        {
            return LibraryContext.Books.FirstOrDefault(x => x.BookId == id);
        }

        public void UpdateReader(Reader inputReader, int id)
        {
            var reader = GetSingleReader(id);
            reader.Name = inputReader.Name;
            reader.Fine = inputReader.Fine;
            reader.UserType = inputReader.UserType;
            reader.VIP = inputReader.VIP;
            LibraryContext.SaveChanges();
        }

        public void RemoveReader(int id)
        {
            var reader = GetSingleReader(id);
            LibraryContext.Remove(reader);
            LibraryContext.SaveChanges();
        }

        public void FineReader(int id)
        {
            var reader = GetSingleReader(id);
            reader.Fine += 10;
            LibraryContext.SaveChanges();
        }

        public void UpdateBook(Book inputBook, int id)
        {
            var book = GetSingleBook(id);
            book.Title = inputBook.Title;
            book.TotalCopies= inputBook.TotalCopies;
            LibraryContext.SaveChanges();
        }

        public void RemoveBook(int id)
        {
            var book = GetSingleBook(id);
            LibraryContext.Remove(book);
            LibraryContext.SaveChanges();
        }
    }
}
