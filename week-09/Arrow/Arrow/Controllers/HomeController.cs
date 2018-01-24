using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Arrow.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        
        [HttpGet("yondu")]
        public IActionResult Yondu([FromQuery]double? distance, [FromQuery] double? time)
        {
            if (distance is null || time is null || time == 0)
            {
                return BadRequest(new { error = "Error occured!"}); 
            }
            return Json(new { distance = distance, time = time, speed = distance / time });
        }
    }
}
