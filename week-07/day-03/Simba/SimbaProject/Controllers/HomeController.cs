using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.ViewModels;

namespace SimbaProject.Controllers
{

    public class HomeController : Controller
    {
        public static ReaderCardViewModel readerCardViewModel= new ReaderCardViewModel();

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("list")]
        public IActionResult List()
        {
            return View(readerCardViewModel);
        }

        [Route("form")]
        public IActionResult Form()
        {
            return View();
        }

        [Route("feeform")]
        public IActionResult FeeForm()
        {
            return View();
        }

        [Route("add")]
        public IActionResult Add(ReaderCard reader)
        {
            readerCardViewModel.ReaderList.Add(reader);
            return RedirectToAction("list");
        }

        [Route("fee")]
        public IActionResult Fee(int id)
        {
            readerCardViewModel.ReaderList[id].Fine += 10;
            return RedirectToAction("list");
        }

        [Route("single/{id?}")]
        public IActionResult SingleReader(int  id)
        {                 
            return View(readerCardViewModel.ReaderList[id]);
        }
    }
}