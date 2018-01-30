using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SimbaProject.Models;
using SimbaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimbaProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public HomeController(ReaderRepository readerRepository)
        {
            ReaderRepository = readerRepository;
        }

        public ReaderRepository ReaderRepository { get; set; }

        [Route("index")]
        public IActionResult Index()
        {            
            return View(ReaderRepository.GetSingleReader(ReaderRepository.CurrentId));
        }

        [HttpGet("")]
        public async Task<IActionResult> LoginForm()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://api.openweathermap.org");
                    var response = await client.GetAsync($"/data/2.5/weather?q=Budapest&appid=d57885984f44e4ee52492f72f12ec085&units=metric");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);
                    return View(new WeatherShortly()
                    {
                        Temp = rawWeather.Main.Temp,
                        Summary = string.Join(",", rawWeather.Weather.Select(x => x.Main)),
                        City = rawWeather.Name
                    });
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest($"Error getting weather from OpenWeather: {httpRequestException.Message}");
                }
            }
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            foreach (Reader reader in ReaderRepository.LibraryContext.Readers)
            {
                if (reader.Name == name)
                {
                    ReaderRepository.CurrentId = reader.ReaderId;
                    return Redirect("index");
                }
            }
            return Redirect("/");
        }
    }
}
