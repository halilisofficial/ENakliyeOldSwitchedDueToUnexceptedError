using Microsoft.AspNetCore.Mvc;

namespace ENakliye.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OverView()//genel bakış
        {
            return View("Index");
        }
        public IActionResult CustomerRequitCostemers()// müşteri müşteri kazandırır
        {
            return View();
        }
        public IActionResult BuisnessPartners()//İş Ortaklarımız
        {
            return View();
        }
        public IActionResult AboutUs()//Hakkımızda
        {
            return View();
        }
        public IActionResult SuccsessStories()//başarı hikayeleri
        {
            return View();
        }
        public IActionResult CustomerReferences()//Müşteri Referansları
        {
            return View();
        }
    }
}
