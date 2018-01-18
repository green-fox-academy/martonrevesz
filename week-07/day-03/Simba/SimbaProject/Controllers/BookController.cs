using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Controllers
{
    [Route("book")]
    public class BookController : Controller
    {
        public BookController(LibraryRepository libraryRepository)
        {
            LibraryRepository = libraryRepository;
        }

        public LibraryRepository LibraryRepository { get; set; }

        [Route("list")]
        public IActionResult Books()
        {
            return View(LibraryRepository.GetBooks());
        }

        [HttpGet("single/{id}")]
        public IActionResult SingleBook(int id)
        {
            var book = LibraryRepository.GetSingleBook(id);
            return View(book);
        }

        [HttpGet("add")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(Book book)
        {
            LibraryRepository.LibraryContext.Books.Add(book);
            LibraryRepository.LibraryContext.SaveChanges();
            return RedirectToAction("books");
        }

        [HttpGet("update/{id}")]
        public IActionResult UpdateForm([FromRoute]int id)
        {
            return View(LibraryRepository.GetSingleBook(id));
        }

        [HttpPost("update/{id}")]
        public IActionResult Update(Book inputBook, [FromRoute] int id)
        {
            LibraryRepository.UpdateBook(inputBook, id);
            return RedirectToAction("books");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            LibraryRepository.RemoveBook(id);
            return RedirectToAction("books");
        }
    }
}
