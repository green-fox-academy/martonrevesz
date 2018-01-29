using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimbaProject.Models;
using SimbaProject.Repositories;
using SimbaProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Controllers
{
    [Route("borrow")]
    public class BorrowController : Controller
    {
        public BorrowController(BorrowService borrowService)
        {
            BorrowService = borrowService;
        }

        public BorrowService BorrowService { get; set; }
        
        [HttpGet("borrow")]
        public IActionResult Borrow([FromQuery] int bookId)
        {
            bookId = 3;
            BorrowService.Borrow(bookId);
            return Ok();
        }

        [HttpGet("back")]
        public IActionResult Back()
        {
            //int bookId = 3;
            //int readerId = 1;
            
            //var book = BookRepository.GetSingleBook(bookId);
            //var reader = ReaderRepository.GetSingleReader(readerId);
            //ReaderRepository.LibraryContext.Entry(book)
            //    .Collection(b => b.BookReaders)
            //    .Load();
            //ReaderRepository.LibraryContext.Entry(reader)
            //    .Collection(b => b.BooksReaders)
            //    .Load();

            //var bookReader = book.BookReaders.FirstOrDefault(x => x.Book == book && x.Reader == reader);

            //book.BookReaders.Remove(bookReader);
            //reader.BooksReaders.Remove(bookReader);
            //ReaderRepository.LibraryContext.SaveChanges();
            return Ok();
        }
    }
}
