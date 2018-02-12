using GoogleAPIDemo.Models;
using GoogleAPIDemo.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace GoogleAPIDemo.Controllers
{

    [Route("")]
    public class HomeController : Controller
    {
        public HomeController(AddressRepository addressRepository)
        {
            AddressRepository = addressRepository;
        }

        public AddressRepository AddressRepository{ get; set; }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult AddAddress(Address address)
        {
            AddressRepository.AddAddress(address);
            return View("index");
        }

        [HttpGet("single/{id}")]
        public async Task<IActionResult> SingleAddress(long id)
        {
            Address address = AddressRepository.GetAddress(id);
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://maps.googleapis.com");
                    var response = await client.GetAsync($"/maps/api/geocode/json?address={address.HouseNumber}, {address.Street}, {address.City}, {address.Country}&key=AIzaSyC5oxgWIg_10OYjIwW-ekzMrYAvJbPWCDY");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rootObject = JsonConvert.DeserializeObject<GoogleData>(stringResult);
                    return View(new LngLat()
                    {
                        Lat = rootObject.results[0].geometry.location.lat,
                        Lng  = rootObject.results[0].geometry.location.lng
                    });
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest($"Error getting weather from Google APIs: {httpRequestException.Message}");
                }
            }
        }
    }
}
