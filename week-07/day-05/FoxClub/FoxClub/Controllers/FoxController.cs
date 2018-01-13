using FoxClub.Models;
using FoxClub.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Controllers
{
    [Route("fox")]
    public class FoxController : Controller
    {
        public FoxContainer FoxContainer { get; set; }

        public FoxController(FoxContainer foxContainer)
        {
            FoxContainer = foxContainer;
        }

        [HttpGet("nutritionstore/{name}")]
        public IActionResult NutritionStore(string name)
        {
            return View(FoxContainer.FoxList.First(x => x.Name == name));
        }


        [HttpGet("nutritionUpdate/{name}")]
        public IActionResult NutritionUpdate(string food, string drink, string name)
        {
            Fox currentfox = FoxContainer.FoxList.First(x => x.Name == name);
            currentfox.Food = food;
            currentfox.Drink = drink;
            return Redirect($"/main/{name}");
        }

        [HttpGet("trickcenter/{name}")]
        public IActionResult TrickCenter(string name)
        {
            return View(FoxContainer.FoxList.First(x => x.Name == name));
        }

        [HttpGet("trickUpdate/{name}")]
        public IActionResult trickUpdate(string trick, string name)
        {
            Fox currentfox = FoxContainer.FoxList.First(x => x.Name == name);
            currentfox.TrickList.Add(trick);
            currentfox.PossibleTricks.Remove(trick);
            return Redirect($"/main/{name}");
        }
    }
}
