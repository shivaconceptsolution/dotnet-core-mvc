using Microsoft.AspNetCore.Mvc;
using WelcomeProject.Models;

namespace WelcomeProject.Controllers
{
    public class SqaurecubeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SquarecbModel obj)
        {
            if (obj.Ope.Equals("Square")) {
                ViewBag.result = obj.Num * obj.Num;
            }
            else
            {
                ViewBag.result = obj.Num * obj.Num * obj.Num;
            }
            return View();
        }
    }
}
