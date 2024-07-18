using Microsoft.AspNetCore.Mvc;

namespace WelcomeProject.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // View Object
        }
        public IActionResult Addition()
        {
            int a = 100;
            int b = 200;
            int c = a + b;
            ViewBag.result = c;
            return View();
        }
    }
}
