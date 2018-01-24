using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MondayFirst.Models;
using MondayFirst.Entities;
using MondayFirst.Services;

namespace MondayFirst.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        public HomeController(LogService logService)
        {
            LogService = logService;
            LogContext = LogContext;
        }

        public LogService LogService { get; set; }
        public LogContext LogContext { get; set; }


        [Route("")] 
        public IActionResult Index()
        {
            LogService.LogIndex();
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {
            //LogContext.Logs.Add(new Log() { Endpoint = "doubling", Data = $"{input}" });
            //LogContext.SaveChanges();

            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            LogContext.Logs.Add(new Log() { Endpoint = "greeter", Data = $"{name}, {title}" });
            LogContext.SaveChanges();

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

            LogContext.Logs.Add(new Log() { Endpoint = "appenda", Data = $"{appendable}" });
            LogContext.SaveChanges();

            if (appendable == null)
            {
                return NotFound();
            }
            return Json(new { appended = appendable + "a" });
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil ([FromBody] Item item, [FromRoute ]string what)
        {
            LogContext.Logs.Add(new Log() { Endpoint = "dountil", Data = $"{item.ToString()}, {what}" });
            LogContext.SaveChanges();

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

        [HttpPost("arrays")]
        public IActionResult Arrays([FromBody] MyArray array)
        {
            LogContext.Logs.Add(new Log() { Endpoint = "arrays", Data = $"{array.ToString()}" });
            LogContext.SaveChanges();

            int result = 0;
            if(array.What.Equals("sum"))
            {
                for (int i = 0; i < array.Numbers.Length; i++)
                {
                    result += array.Numbers[i];
                }
                return Json(new { result = result });
            } 
            else if(array.What.Equals("multiply"))
            {
                result = 1;
                for (int i = 0; i < array.Numbers.Length; i++)
                {
                    result *= array.Numbers[i];
                    
                }
                return Json(new { result = result });
            }
            else if (array.What.Equals("double"))
            {
                for (int i = 0; i < array.Numbers.Length; i++)
                {
                    array.Numbers[i] *= 2;
                }
                return Json(new { result = array.Numbers });
            }
            return Json(new { error = "Please provide what to do with the numbers!" });
        }

        [HttpGet("log")]
        public IActionResult Log()
        {
            LogContext.Logs.Add(new Log() { Endpoint = "log", Data=""});
            LogContext.SaveChanges();

            return Json(new { entries = LogContext.Logs, entry_count = LogContext.Logs.ToList().Count});
        }


        [HttpPost("sith")]
        public IActionResult Sith([FromBody] Text text)
        {

            LogContext.Logs.Add(new Log() { Endpoint = "sith", Data = text.Words });
            LogContext.SaveChanges();

            if (text.Words is null || text.Words.Equals(string.Empty))
            {
                return Json(new {error = "Feed me some text you have to, padawan young you are. Hmmm."});
            }
            string[] myArray = text.Words.Split();
            for (int i = 0; i < myArray.Length - 1; i+=2)
            {
                string temp = myArray[i];
                myArray[i] = myArray[i + 1];
                myArray[i + 1] = temp;
            }
            string final = string.Join(' ', myArray);
            final += " random text at the end";

            return Json( new { sith_text = final});
        }
    }
}
