using Microsoft.AspNetCore.Mvc;
using APIProject.Models;

namespace APIProject.Controllers
{
    public class ChampionController : Controller
    {
        public IActionResult Index()
        {
            Champion model = new Champion(0, "aatrox");
            return View(model);                
        }                                

        public IActionResult ChampSelect(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
