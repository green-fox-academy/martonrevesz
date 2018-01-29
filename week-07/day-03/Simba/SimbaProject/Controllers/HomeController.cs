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
        public HomeController(ReaderRepository readerRepository)
        {
            ReaderRepository = readerRepository;
        }

        public ReaderRepository ReaderRepository { get; set; }

        [Route("index")]
        public IActionResult Index()
        {            
            return View(ReaderRepository.GetSingleReader(ReaderRepository.CurrentId));
        }

        [HttpGet("")]
        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            foreach (Reader reader in ReaderRepository.LibraryContext.Readers)
            {
                if (reader.Name == name)
                {
                    ReaderRepository.CurrentId = reader.ReaderId;
                    return Redirect("index");
                }
            }
            return Redirect("/");
        }
    }
}
