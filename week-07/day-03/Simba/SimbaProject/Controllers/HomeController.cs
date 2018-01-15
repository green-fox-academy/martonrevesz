using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.ViewModels;
using SimbaProject.Repositories;

namespace SimbaProject.Controllers
{

    public class HomeController : Controller
    {
        public HomeController(LibraryRepository libraryRepository)
        {
            LibraryRepository = libraryRepository;
        }

        public LibraryRepository LibraryRepository{ get; set; }

        

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var readerList = LibraryRepository.GetReaders();
            return View(readerList);
        }

        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(Reader reader)
        {
            LibraryRepository.LibraryContext.Readers.Add(reader);
            LibraryRepository.LibraryContext.SaveChanges();
            return RedirectToAction("list");
        }

        //[HttpGet("updateForm/{id}")]
        //public IActionResult UpdateForm([FromRoute]int id)
        //{
        //    return View(readerCardViewModel.ReaderList.First(x => x.Id == id));
        //}

        //[HttpGet("updateData/{id}")]
        //public IActionResult Update(
        //    [FromQuery]string name, [FromQuery]int fine, [FromQuery]string userType, [FromQuery]string VIP, [FromRoute] int id)
        //{
        //    var reader = readerCardViewModel.ReaderList.First(x => x.Id == id);
        //    reader.Name = name;
        //    reader.Fine = fine;
        //    reader.UserType = userType;
        //    reader.VIP = VIP == "1" ? true : false;

        //    return RedirectToAction("list");
        //}

        //[HttpGet("delete/{id}")]
        //public IActionResult Delete([FromRoute]int id)
        //{
        //    readerCardViewModel.ReaderList.Remove(readerCardViewModel.ReaderList.First(x => x.Id == id));
        //    return RedirectToAction("list");
        //}

        //[HttpGet("fee/{id}")]
        //public IActionResult Fee(int id)
        //{
        //    readerCardViewModel.ReaderList.First(x => x.Id == id).Fine += 10;
        //    return RedirectToAction("list");
        //}

        [HttpGet("single/{id}")]
        public IActionResult SingleReader(int id)
        {
            var reader = LibraryRepository.GetSingleReader(id);
            return View(reader);
        }


    }
}