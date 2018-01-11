using GreetSomeOne.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOne.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public Person Person { get; set; }

        public HomeController(Person person)
        {
            Person = person;
        }      

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Post(Person person)
        {
            Person.Name = person.Name;
            return RedirectToAction("greet");
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return View(Person);
        }
    }
}
