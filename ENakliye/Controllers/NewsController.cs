using Microsoft.AspNetCore.Mvc;

namespace ENakliye.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OverView()//genel bakış
        {
            return View();
        }
        public IActionResult LatestUpdates()//Yenilikler
        {
            return View();
        }
        public IActionResult Journal()//Bülten
        {
            return View();
        }
    }
}
