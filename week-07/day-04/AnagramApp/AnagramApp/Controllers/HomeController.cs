using Microsoft.AspNetCore.Mvc;
using AnagramApp.Models;

namespace AnagramApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public AnagramChecker AnagramChecker;

        public HomeController(AnagramChecker anagramChecker)
        {
            AnagramChecker = anagramChecker;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("check")]
        public IActionResult Check(string anagram1, string anagram2)
        {
            AnagramChecker.AreAnagrams(anagram1, anagram2);
            return RedirectToAction("result");
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View(AnagramChecker);
        }
    }
}
