using Microsoft.AspNetCore.Mvc;

namespace WelcomeProject.Controllers
{
    public class SIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calc(IFormCollection obj)
        {
            float p = Convert.ToSingle(obj["txtp"]);
            float r = Convert.ToSingle(obj["txtr"]);
            float t = Convert.ToSingle(obj["txtt"]);
            float s = (p * r * t) / 100;
            ViewBag.result = "Result is "+s;

            return View();
        }
    }
}
