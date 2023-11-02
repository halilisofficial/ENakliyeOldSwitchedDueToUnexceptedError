using Microsoft.AspNetCore.Mvc;

namespace ENakliye.Controllers
{
    public class ServisController : Controller//Hizmetler controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OverView()// Genel Bakış
        {
            return View("Index");
        }
        public IActionResult TransportBaroMeter()// Nakliye Barometresi
        {
            return View();
        }
        public IActionResult TransportDictionary()//Nakliye Sözlüğü
        {
            return View();
        }
        public IActionResult Security()//Güvenlik
        {
            return View();
        }
        public IActionResult Download()//Indir
        {
            return View();
        }
        public IActionResult InternationalDebtCollection()//Uluslararası tahsilat
        {
            return View();
        }
        public IActionResult FreightExchangeInterface()//yük borsası arayüzü 
        {
            return View();
        }
        public IActionResult TransportOrderInterface()//nakliye siparişleri arayüzü
        {
            return View();
        }
        public IActionResult TrackingInterface()//takip arayüzü
        {
            return View();
        }
        public IActionResult LoadPartialView(string partialViewName)
        {
            return PartialView(partialViewName);
        }
    }
}
