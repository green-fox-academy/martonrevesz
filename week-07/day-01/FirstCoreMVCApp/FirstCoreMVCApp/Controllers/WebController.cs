using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstCoreMVCApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstCoreMVCApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        static int counter;

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = $"{name}! This site was loaded {++counter} times since last server start"
            };
            return View(greeting);
        }
    }
}
