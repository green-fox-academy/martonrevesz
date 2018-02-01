using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Controllers
{
    [Route("author")]
    public class AuthorController : Controller
    {
        public AuthorController(AuthorService authorService)
        {
            AuthorService = authorService;
        }

        public AuthorService AuthorService { get; set; }

        [HttpPost("add")]
        public IActionResult AddAuthor(Author author)
        {
            AuthorService.Add(author);
            return Ok();
        }

        [HttpGet("add")]
        public IActionResult Add(Author author)
        {
            return View();
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return View(AuthorService.GetReaderAuthorsViewModel());
        }
    }
}
