using Microsoft.AspNetCore.Mvc;

namespace ENakliye.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class UserHomeController : Controller
    {
        public IActionResult IndexHomeUser()
        {
            return View();
        }
        [Route("user/UserFreightExchange")]
        public IActionResult UserFreightExchange()
        {
            return View();
        }
        [Route("user/UserVehicleSpace")]
        public IActionResult UserVehicleSpace()
        {
            return View();
        }
        [Route("user/UserWarehouse")]
        public IActionResult UserWarehouse()
        {
            return View();
        }
        [Route("user/UserAdvert")]
        public IActionResult UserAdvert()
        {
            return View();
        }
        [Route("user/UserRoutes")]
        public IActionResult UserRoutes()
        {
            return View();
        }
        [Route("user/UserStatistic")]
        public IActionResult UserStatistic()
        {
            return View();
        }
        [Route("user/UserSettings")]
        public IActionResult UserSettings()
        {
            return View();
        }
        public IActionResult UserLogOut()
        {
            return View();
        }
    }
}
