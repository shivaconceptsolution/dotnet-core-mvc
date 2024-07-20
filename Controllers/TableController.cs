using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace WelcomeProject.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()  //Load Method
        {
            return View();
        }

        public IActionResult Calc(IFormCollection obj) //Action Method
        {
            int num = Convert.ToInt32(obj["txtnum"]);

            List<Int32> lst = new List<Int32>();
            for(int i=1;i<=10;i++)
            {
                int r = num * i;
                lst.Add(r);
            }
            ViewBag.result = lst;
            return View("Index");
        }
    }
}
