using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cargos.Models;

namespace Cargos.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        public HomeController(Cargo cargo)
        {
            Cargo = cargo;
        }

        public Cargo Cargo { get; set; }

        [HttpGet("rocket")]
        public IActionResult Get()
        {
            return Json(new { caliber25 = Cargo.Caliber25, caliber30 = Cargo.Caliber30,
                caliber50 = Cargo.Caliber50, shipstatus = Cargo.ShipStatus , ready = Cargo.Ready });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
