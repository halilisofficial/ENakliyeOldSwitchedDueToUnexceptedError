using Microsoft.AspNetCore.Mvc;

namespace ENakliye.Controllers
{
    public class ProductController : Controller//ürünler controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OverView()//genel bakış
        {
            return View("Index");
        }
        public IActionResult Advert()//ilanlar
        {
            return View();
        }
        public IActionResult Warehouse()//depo
        {
            return View();
        }
        public IActionResult Tracking()//izleme
        {
            return View();
        }
        public IActionResult RatingsFeature()//Değerlendirme fonsiyonu
        {
            return View();
        }
        #region yük borsası
        public IActionResult Freight()//yükler fonsiyonu
        {
            return View();
        }
        public IActionResult VehicleSpace()//Boş Araç fonsiyonu
        {
            return View();
        }
        public IActionResult ClosedFreightExchange()//Kapalı Yük Borsası fonsiyonu
        {
            return View();
        }
        #endregion
        public IActionResult ShipmentTracking()//Nakliye Takibi
        {
            return View();
        }

        public IActionResult TransportOrders()//Nakliyat İşleri
        {
            return View();
        }
        #region arayüzler
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
        #endregion
    }
}
