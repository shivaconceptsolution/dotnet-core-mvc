using Microsoft.AspNetCore.Mvc;
using WelcomeProject.Models;

namespace WelcomeProject.Controllers
{
    public class SalaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SalaryCalc obj)
        {
            double totalsal = obj.Basic + obj.Ta + obj.Da + obj.Comm;
            double gsal = totalsal - (totalsal / 30) * obj.Nol-obj.Pf;
            ViewBag.result = "Gross Salary is " + gsal;
            return View();
        }
    }
}
