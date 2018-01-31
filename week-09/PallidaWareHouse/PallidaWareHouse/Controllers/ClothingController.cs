using Microsoft.AspNetCore.Mvc;
using PallidaWareHouse.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaWareHouse.Controllers
{
    public class ClothingController : Controller
    {
        public ClothingController(ClothingRepository clothingRepository)
        {
            ClothingRepository = clothingRepository;
        }

        public ClothingRepository ClothingRepository { get; set; }
    }
}
