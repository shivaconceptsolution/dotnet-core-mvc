using Microsoft.AspNetCore.Mvc;
using WelcomeProject.Models;

namespace WelcomeProject.Controllers
{
    public class SwapController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        public IActionResult Index(Swap obj)
        {
            int a = obj.A;
            int b = obj.B;
            int temp;
            temp = a;
            a = b;
            b=temp;
            ViewBag.result = "a=" + a + " b=" + b;
            return View("Index");
        }
    }
}
