using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MondayFirst.Controllers
{
    [Route("/api/[controller]")]
    public class ValuesController : Controller
    {

        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

    }
}
