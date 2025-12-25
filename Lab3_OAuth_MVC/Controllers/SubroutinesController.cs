using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_OAuth_MVC.Controllers
{
    [Authorize]
    public class SubroutinesController : Controller
    {
        public IActionResult Task1()
        {
            return View();
        }

        public IActionResult Task2()
        {
            return View();
        }

        public IActionResult Task3()
        {
            return View();
        }
    }
}
