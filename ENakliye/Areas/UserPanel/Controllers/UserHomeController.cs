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
    }
}
