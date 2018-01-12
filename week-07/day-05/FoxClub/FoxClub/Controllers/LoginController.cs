using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using FoxClub.ViewModels;

namespace FoxClub.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        public FoxContainer FoxContainer { get; set; }

        public LoginController(FoxContainer foxContainer)
        {
            FoxContainer = foxContainer;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            foreach (Fox fox in FoxContainer.FoxList)
            {
                if (fox.Name == name)
                {
                    return Redirect($"main/{name}");
                }                
            }
            return Redirect("/");

        }
    }
}
