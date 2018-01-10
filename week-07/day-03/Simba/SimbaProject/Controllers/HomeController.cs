using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.ViewModels;

namespace SimbaProject.Controllers
{
    

    [Route("")]
    public class HomeController : Controller
    {
        public static ReaderCardViewModel readerCardViewModel= new ReaderCardViewModel();

        [Route("list")]
        public IActionResult List()
        {
            return View(readerCardViewModel);
        }
        [Route("gerzson")]
        public IActionResult Index()
        {
            var account = new ReaderCard()
            {
                Name = "Gerzson",
                Balance = "0",
                UserType = "Professor"
            };                            
            return View(account);
        }
    }
}