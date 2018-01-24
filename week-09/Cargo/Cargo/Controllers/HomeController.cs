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

        [HttpGet("fill")]
        public IActionResult Fill([FromQuery]int caliber,[FromQuery] int amount)
        {
            if (caliber == 25)
                Cargo.Caliber25 += amount;
            if (caliber == 30)
                Cargo.Caliber30 += amount;
            if (caliber == 50)
                Cargo.Caliber50 += amount;
            int total = Cargo.Caliber25 + Cargo.Caliber30 + Cargo.Caliber50;
            Cargo.ShipStatus = Convert.ToString(total / 12500);
            if (Cargo.ShipStatus == "0")
            {
                Cargo.ShipStatus = "empty";
            }
            if (total >= 12500)
                Cargo.Ready = true;

            return Json(new
            {
                received = caliber,
                amount = amount,
                shipstatus = Cargo.ShipStatus,
                ready = Cargo.Ready
            });
        }
    }
}
