using SimbaProject.Models;
using SimbaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Services
{
    public class BookService
    {
        public BookService(BookRepository bookRepository)
        {
            BookRepository = bookRepository;
        }

        public BookRepository BookRepository { get; set; }

        public List<Book> GetBooks()
        {
            return BookRepository.GetBooks();
        }

        public Book GetSingleBook(int id)
        {
            return BookRepository.GetSingleBook(id);
        }

        public void Add(Book book)
        {
            BookRepository.Add(book);
        }

        public void UpdateBook(Book inputBook, int id)
        {
            BookRepository.UpdateBook(inputBook, id);
        }

        public void RemoveBook(int id)
        {
            BookRepository.RemoveBook(id);
        }
    }
}
