using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Controllers
{
    [Route("api")]
    public class GuardianController : Controller
    {

        [HttpGet("groot")]
        public IActionResult Get([FromQuery] string message)
        {
            if (message is null || message.Length == 0)
            {
                return Json(new { error = "I am Groot!" });
            }
            return Json(new {received=message, translated="I am Groot!"});
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
