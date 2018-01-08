using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SayHello.Models;

namespace SayHello.Controllers
{
    [Route("[controller]")]
    public class HelloController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            var container = new Container();
            return View(container);
        }
    }
}