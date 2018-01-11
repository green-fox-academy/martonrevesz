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
        public ReaderCardViewModel readerCardViewModel;

        public HomeController(ReaderCardViewModel readerCardViewModel)
        {
            this.readerCardViewModel = readerCardViewModel;
        }

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

        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(ReaderCard reader)
        {
            readerCardViewModel.ReaderList.Add(reader);
            return RedirectToAction("list");
        }

        [HttpGet("updateForm/{id}")]
        public IActionResult UpdateForm([FromRoute]int id)
        {
            return View(readerCardViewModel.ReaderList.First(x => x.Id == id));
        }

        [HttpGet("updateData/{id}")]
        public IActionResult Update(
            [FromQuery]string name, [FromQuery]int fine, [FromQuery]string userType, [FromQuery]string VIP, [FromRoute] int id)
        {
            var reader = readerCardViewModel.ReaderList.First(x => x.Id == id);
            reader.Name = name;
            reader.Fine = fine;
            reader.UserType = userType;
            reader.VIP = VIP == "1" ? true : false;

            return RedirectToAction("list");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            readerCardViewModel.ReaderList.Remove(readerCardViewModel.ReaderList.First(x => x.Id == id));
            return RedirectToAction("list");
        }

        [HttpGet("fee/{id}")]
        public IActionResult Fee(int id)
        {
            readerCardViewModel.ReaderList.First(x => x.Id == id).Fine += 10;
            return RedirectToAction("list");
        }

        [HttpGet("single/{id}")]
        public IActionResult SingleReader(int  id)
        {                 
            return View(readerCardViewModel.ReaderList.First(x => x.Id == id));
        }
    }
}