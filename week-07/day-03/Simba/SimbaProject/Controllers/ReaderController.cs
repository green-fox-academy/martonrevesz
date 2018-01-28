using Microsoft.AspNetCore.Mvc;
using SimbaProject.Models;
using SimbaProject.Services;

namespace SimbaProject.Controllers
{
    [Route("reader")]
    public class ReaderController : Controller
    {
        public ReaderController(ReaderService readerService)
        {
            ReaderService = readerService;
        }

        public ReaderService ReaderService { get; set; }



        [HttpGet("list")]
        public IActionResult List()
        {        
            return View(ReaderService.GetReaders());
        }

        [HttpGet("add")]
        public IActionResult Form()
        {
            return View();
        }
        
        [HttpPost("add")]
        public IActionResult Add(Reader reader)
        {
            ReaderService.Add(reader);
            return RedirectToAction("list");
        }

        [HttpGet("update")]
        public IActionResult UpdateForm([FromQuery]int id)
        {
            return View(ReaderService.GetSingleReader(id));
        }

        [HttpPost("update")]
        public IActionResult Update(Reader inputReader, [FromQuery] int id)
        {
            ReaderService.UpdateReader(inputReader, id);
            return RedirectToAction("list");
        }

        [HttpGet("delete")]
        public IActionResult Delete([FromQuery]int id)
        {
            ReaderService.RemoveReader(id);
            return RedirectToAction("list");
        }

        [HttpGet("fee")]
        public IActionResult Fee([FromQuery] int id)
        {
            ReaderService.FineReader(id);
            return RedirectToAction("list");
        }

        [HttpGet("single")]
        public IActionResult SingleReader([FromQuery] int id)
        {
            var reader = ReaderService.GetSingleReader(id);
            return View(reader);
        }
    }
}