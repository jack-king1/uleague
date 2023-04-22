using Microsoft.AspNetCore.Mvc;
using APIProject.Models;
using System.Net.Http;

namespace APIProject.Controllers
{
    public class ChampionController : Controller
    {
        public IActionResult Index()
        {
            return View();                
        }                                

        public IActionResult ChampSelect(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        public async Task<IActionResult> All()
        {
            // Create an instance of the model
            var championAPI = new ChampionAPI();

            // Call the model method to retrieve data from the API
            dynamic jsonData = await championAPI.GetAllChampionDataFromApiAsync();

            // Pass the retrieved data to the view
            
            
            return View(jsonData);
        }

        public async Task<IActionResult> Detail(string champName)
        {
            var championAPI = new ChampionAPI();

            dynamic jsonData = await championAPI.GetChampionDataFromApiAsync(champName);

            return View(jsonData);
        }
    }
}
