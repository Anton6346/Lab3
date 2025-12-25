using Microsoft.AspNetCore.Mvc;

namespace Lab3_OAuth_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
