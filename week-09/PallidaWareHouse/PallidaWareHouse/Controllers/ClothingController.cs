using Microsoft.AspNetCore.Mvc;
using PallidaWareHouse.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaWareHouse.Controllers
{
    [Route("warehouse")]
    public class ClothingController : Controller
    {
        public ClothingController(ClothingRepository clothingRepository)
        {
            ClothingRepository = clothingRepository;
        }

        public ClothingRepository ClothingRepository { get; set; }

        [HttpGet("")]
        public IActionResult Warehouse()
        {
            return View(ClothingRepository.GetShoppingViewModel());
        }

        [HttpPost("summary")]
        public IActionResult Summary([FromForm]string itemName, [FromForm]string size, [FromForm]int quantity)
        {            
            return View(ClothingRepository.CalculateSummary(itemName, size, quantity));
        }

        [HttpGet("query")]
        public IActionResult Query([FromQuery] int? price, [FromQuery] string type)
        {
            if (price == null || type == null)
            {
                return BadRequest();
            }
            return Json(new { result = "ok", clothes = ClothingRepository.GetQueryList(price, type) });
        }
    }
}
