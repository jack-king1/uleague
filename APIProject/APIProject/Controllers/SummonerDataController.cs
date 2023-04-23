using APIProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    public class SummonerDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Summoner(string name)
        {
            // Create an instance of the model
            var summonerModel = new SummonerDataModel();
            // Call the model method to retrieve data from the API
            dynamic summonerData = await summonerModel.GetSummonrDataFromApiAsync(name);

            // Pass the retrieved data to the view


            return View("Index", summonerData);
        }
    }
}
