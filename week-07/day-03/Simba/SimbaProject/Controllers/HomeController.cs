using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public HomeController(LibraryRepository libraryRepository)
        {
            LibraryRepository = libraryRepository;
        }

        public LibraryRepository LibraryRepository { get; set; }

        [Route("index")]
        public IActionResult Index()
        {            
            return View();
        }

        [HttpGet("")]
        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            foreach (Reader reader in LibraryRepository.LibraryContext.Readers)
            {
                if (reader.Name == name)
                {
                    LibraryRepository.CurrentId = reader.ReaderId;
                    return Redirect("index");
                }
            }
            return Redirect("/");
        }
    }
}
