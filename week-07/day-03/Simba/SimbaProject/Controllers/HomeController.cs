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

        [Route("add")]
        public IActionResult Add(ReaderCard reader)
        {
            readerCardViewModel.ReaderList.Add(reader);
            return RedirectToAction("list");
        }

        [Route("updateForm/{id}")]
        public IActionResult UpdateForm(int id)
        {
            return View(readerCardViewModel.ReaderList.First(x => x.Id == id));
        }

        [Route("updateData/{id}")]
        public IActionResult Update(ReaderCard reader, int id)
        {
            readerCardViewModel.ReaderList.First(x => x.Id == id).Name = reader.Name;
            readerCardViewModel.ReaderList.First(x => x.Id == id).Fine = reader.Fine;
            readerCardViewModel.ReaderList.First(x => x.Id == id).UserType= reader.UserType;
            readerCardViewModel.ReaderList.First(x => x.Id == id).VIP = reader.VIP;
            return RedirectToAction("list");
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            readerCardViewModel.ReaderList.Remove(readerCardViewModel.ReaderList.First(x => x.Id == id));
            return RedirectToAction("list");
        }

        [Route("fee/{id}")]
        public IActionResult Fee(int id)
        {
            readerCardViewModel.ReaderList.First(x => x.Id == id).Fine += 10;
            return RedirectToAction("list");
        }

        [Route("single/{id}")]
        public IActionResult SingleReader(int  id)
        {                 
            return View(readerCardViewModel.ReaderList.First(x => x.Id == id));
        }
    }
}