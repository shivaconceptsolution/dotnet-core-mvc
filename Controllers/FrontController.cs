using Microsoft.AspNetCore.Mvc;

namespace WelcomeProject.Controllers
{
    public class FrontController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Contactus()
        {
            return View();
        }


    }
}
