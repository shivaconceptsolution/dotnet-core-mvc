using Microsoft.AspNetCore.Mvc;
using WelcomeProject.Models;

namespace WelcomeProject.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AddModel obj,IFormCollection obj1)
        {
            int a = obj.Num1;
            int b = obj.Num2;
            int c=0;
            String ope = obj1["btnsubmit"].ToString();
            if(ope=="+")
            {
                c = a + b;
            }
            else if(ope=="-")
            {
                c=a- b;
            }
            else if(ope== "*")
            {
                c = a * b;
            }
            else if(ope== "/")
            {
                c = a / b;
            }
            ViewBag.result = "Result is "+c;
            return View();
        }
    }
}
