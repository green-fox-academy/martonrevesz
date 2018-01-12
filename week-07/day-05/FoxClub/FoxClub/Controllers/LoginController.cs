using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

namespace FoxClub.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            return Redirect($"main/{name}");
        }
    }
}
