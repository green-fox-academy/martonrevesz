using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimbaProject.Models;
using SimbaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Controllers
{
    [Route("borrow")]
    public class BookReaderController : Controller
    {
        public BookReaderController(LibraryRepository libraryRepository)
        {
            LibraryRepository = libraryRepository;
        }

        public LibraryRepository LibraryRepository { get; set; }

        [HttpGet("borrow")]
        public IActionResult Borrow()
        {
            int bookId = 5;
            int readerId = 4;

            var book = LibraryRepository.GetSingleBook(bookId);
            var reader = LibraryRepository.GetSingleReader(readerId);
            var bookreader = new BookReader() { Book = book, Reader = reader };
            book.BookReaders.Add(bookreader);
            reader.BooksReaders.Add(bookreader);
            LibraryRepository.LibraryContext.SaveChanges();
            return Ok();
        }

        [HttpGet("back")]
        public IActionResult Back()
        {
            int bookId = 1;
            int readerId = 2;
            
            var book = LibraryRepository.GetSingleBook(bookId);
            var reader = LibraryRepository.GetSingleReader(readerId);
            LibraryRepository.LibraryContext.Entry(book)
                .Collection(b => b.BookReaders)
                .Load();
            LibraryRepository.LibraryContext.Entry(reader)
                .Collection(b => b.BooksReaders)
                .Load();

            var bookReader = book.BookReaders.FirstOrDefault(x => x.Book == book && x.Reader == reader);

            book.BookReaders.Remove(bookReader);
            reader.BooksReaders.Remove(bookReader);
            LibraryRepository.LibraryContext.SaveChanges();
            return Ok();
        }
    }
}
