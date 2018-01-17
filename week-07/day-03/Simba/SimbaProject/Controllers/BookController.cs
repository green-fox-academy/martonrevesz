using Microsoft.AspNetCore.Mvc;
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
    }
}
