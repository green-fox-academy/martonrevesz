using FoxClub.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Controllers
{

    [Route("main/{name}")]
    public class MainController : Controller
    {
        public FoxContainer FoxContainer { get; set; }

        public MainController(FoxContainer foxContainer)
        {
            FoxContainer = foxContainer;
        }

        public IActionResult Index(string name)
        {
            return View();
        }
        
    }
}
