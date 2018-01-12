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

        [Route("")]
        public IActionResult Index(string name)
        {
            var fox = FoxContainer.FoxList.First(x => x.Name == name);
            return View(fox);
        }
        
    }
}
