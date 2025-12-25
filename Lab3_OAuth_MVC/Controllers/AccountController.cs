using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_OAuth_MVC.Controllers
{
    public class AccountController : Controller
    {
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
            return SignOut("Cookies");
        }
    }
}
