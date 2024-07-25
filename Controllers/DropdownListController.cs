using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WelcomeProject.Models;

namespace WelcomeProject.Controllers
{
    public class DropdownListController : Controller
    {
        public IActionResult Index()
        {
            var items = new List<Products>
        {
            new Products { Pid = 1, Pname = "Item 1" },
            new Products { Pid = 2, Pname = "Item 2" },
            new Products { Pid = 3, Pname = "Item 3" }
        };
             ViewBag.Items = new SelectList(items, "Pid", "Pname");
            return View();
        }
        [HttpPost]
        public IActionResult Index(int selectedItemId)
        {
            var items = new List<Products>
        {
            new Products { Pid = 1, Pname = "Item 1" },
            new Products { Pid = 2, Pname = "Item 2" },
            new Products { Pid = 3, Pname = "Item 3" }
        };
            ViewBag.Items = new SelectList(items, "Pid", "Pname");
            ViewBag.result = selectedItemId;
            return View();
        }
    }
}
