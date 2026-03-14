using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCProject1.Models;

namespace MVCProject1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Student()
        {
            var s = new { Name = "Karan", Marks = 90 };
            return Json(s);
        }

        public IActionResult Test()
        {
            return NotFound();
        }

        public IActionResult Square(int? number)
        {
            if (number == null)
            {
                return Content("Please Provide a number");
            }
            return View(number.Value);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
