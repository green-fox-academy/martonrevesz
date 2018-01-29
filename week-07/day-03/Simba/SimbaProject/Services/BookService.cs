using SimbaProject.Models;
using SimbaProject.Repositories;
using SimbaProject.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Services
{
    public class BookService
    {
        public BookService(BookRepository bookRepository, ReaderRepository readerRepository)
        {
            BookRepository = bookRepository;
            ReaderRepository = readerRepository;
        }

        public BookRepository BookRepository { get; set; }
        public ReaderRepository ReaderRepository { get; set; }

        public List<Book> GetBooks()
        {
            return BookRepository.GetBooks();
        }

        public ReaderBookViewModel GetSingleBook(int id)
        {
            var readerBookViewModel = new ReaderBookViewModel()
            {
                Book = BookRepository.GetSingleBook(id),
                Reader = ReaderRepository.GetSingleReader(ReaderRepository.CurrentId)
            };
            return readerBookViewModel;
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
