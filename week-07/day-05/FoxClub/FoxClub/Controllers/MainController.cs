using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Controllers
{

    [Route("main/{name?}")]
    public class MainController : Controller
    {
        public IActionResult Index(string name)
        {
            return View();
        }
        
    }
}
