using Microsoft.AspNetCore.Mvc;

namespace ENakliye.Controllers
{
    public class ContuctController : Controller
    {
        public IActionResult Index()//tek sayfa iletişim bilgileri
        {
            return View();
        }
    }
}
