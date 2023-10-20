using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ENakliye.Models;

namespace ENakliye.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
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
        /* 
        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            // Kullanıcı giriş bilgilerini doğrulama ve işlemler burada yapılır.
            // Örnek olarak, kullanıcıyı oturum açmış olarak işaretleme işlemi yapılabilir.

            if (ModelState.IsValid)
            {
                // Kullanıcıyı oturum açmış olarak işaretleme işlemi
                // FormsAuthentication veya Identity kullanılabilir.
                // Örneğin, Identity kullanımı:
                var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, model.UserName),
            }, "custom"));

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, user);

                return RedirectToAction(actionName: "Index", controllerName: "Home"); // Başka bir sayfaya yönlendirme
            }

            return View(model);
        }
        */
    }
}