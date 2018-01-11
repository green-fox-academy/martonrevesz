using Project1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private Counter counter;

        public HomeController(Counter counter)
        {
            this.counter = counter;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost("")]
        public IActionResult Action()
        {
            ++this.counter.counter;
            return RedirectToAction("Index");
        }
    }
}
