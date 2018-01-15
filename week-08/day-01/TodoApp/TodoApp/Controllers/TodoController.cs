using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        [Route("")]
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
