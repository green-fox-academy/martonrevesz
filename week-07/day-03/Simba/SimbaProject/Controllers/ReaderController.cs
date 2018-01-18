using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.Repositories;

namespace SimbaProject.Controllers
{
    [Route("reader")]
    public class ReaderController : Controller
    {
        public ReaderController(LibraryRepository libraryRepository)
        {
            LibraryRepository = libraryRepository;
        }

        public LibraryRepository LibraryRepository { get; set; }


        [HttpGet("list")]
        public IActionResult List()
        {        
            return View(LibraryRepository.GetReaders());
        }

        [HttpGet("add")]
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

        [HttpGet("update")]
        public IActionResult UpdateForm([FromQuery]int id)
        {
            return View(LibraryRepository.GetSingleReader(id));
        }

        [HttpPost("update")]
        public IActionResult Update(Reader inputReader, [FromQuery] int id)
        {
            LibraryRepository.UpdateReader(inputReader, id);
            return RedirectToAction("list");
        }

        [HttpGet("delete")]
        public IActionResult Delete([FromQuery]int id)
        {
            LibraryRepository.RemoveReader(id);
            return RedirectToAction("list");
        }

        [HttpGet("fee")]
        public IActionResult Fee([FromQuery] int id)
        {
            LibraryRepository.FineReader(id);
            return RedirectToAction("list");
        }

        [HttpGet("single")]
        public IActionResult SingleReader([FromQuery] int id)
        {
            var reader = LibraryRepository.GetSingleReader(id);
            return View(reader);
        }
    }
}