using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MondayFirst.Models;

namespace MondayFirst.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {

        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear student!" });
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA (string appendable)
        {
            if (appendable == null)
            {
                return NotFound();
            }
            return Json(new { appended = appendable + "a" });
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil ([FromBody] Item item, [FromRoute ]string what)
        {
            if (item.Until == null)
            {
                return Json(new { error = "Please provide a number!"});
            }
            if (what.Equals("sum"))
            {
                int result = (int)item.Until * ((int)item.Until + 1) / 2;
                return Json(new { result = result });
            }
            if (what.Equals("factor"))
            {
                int result = 1;
                while ((int)item.Until != 1)
                {
                    result *= (int)item.Until;
                    item.Until--;
                }
                return Json(new { result = result });
            }
            return NotFound();
        }

    }
}
