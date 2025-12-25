using Lab3_OAuth_MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_OAuth_MVC.Controllers
{
    public class AccountController : Controller
    {
        // ===== REGISTER =====
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Імітація збереження користувача
            // (для лабораторної БД не обовʼязкова)

            return RedirectToAction("Login");
        }

        // ===== OAUTH LOGIN =====
        public IActionResult Login()
        {
            return Challenge(
                new AuthenticationProperties
                {
                    RedirectUri = "/Account/Profile"
                },
                GoogleDefaults.AuthenticationScheme
            );
        }

        [Authorize]
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return SignOut(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
