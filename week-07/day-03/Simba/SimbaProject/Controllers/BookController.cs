using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.Repositories;
using SimbaProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Controllers
{
    [Route("book")]
    public class BookController : Controller
    {
        public BookController(BookService bookService)
        {
            BookService = bookService;
        }

        public BookService BookService { get; set; }


        [Route("list")]
        public IActionResult Books(int id)
        {
            return View(BookService.GetBooks());
        }

        [HttpGet("single/{id}")]
        public IActionResult SingleBook([FromRoute] int id)
        {
            var readerBookViewModel = BookService.GetSingleBook(id);
            return View(readerBookViewModel);
        }

        [HttpGet("add")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(Book book)
        {
            BookService.Add(book);
            return RedirectToAction("books");
        }

        [HttpGet("update/{id}")]
        public IActionResult UpdateForm([FromRoute]int id)
        {
            return View(BookService.GetSingleBook(id));
        }

        [HttpPost("update/{id}")]
        public IActionResult Update(Book inputBook, [FromRoute] int id)
        {
            BookService.UpdateBook(inputBook, id);
            return RedirectToAction("books");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            BookService.RemoveBook(id);
            return RedirectToAction("books");
        }
    }
}
