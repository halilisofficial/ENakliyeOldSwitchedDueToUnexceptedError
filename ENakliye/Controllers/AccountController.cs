using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ENakliye.Models;

namespace ENakliye.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult ForgetPassword()
        {
            return View();
        }
        public ActionResult ForgetPasswordEmailSent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginControl(UserModel model)
        {
            if (ModelState.IsValid)
            {
                string gmail = model.Gmail;
                string password = model.Password;
                if (true)//validasyon işlemi yapılacaktır
                {
                    return RedirectToRoute("userAreaDefault", new { area = "UserPanel", controller = "UserHome", action = "IndexHomeUser" });
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}