using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCProject2.Models;

namespace MVCProject2.Controllers
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
        public IActionResult Send()
        {
            TempData["a"] = "karan";
            TempData["b"] = "jagriti";
            return RedirectToAction("Recieve", "Student");
        }

        public IActionResult SendNumber()
        {
            TempData["x"] = 5;
            return RedirectToAction("RecieveNumber", "Student");
        }

        public IActionResult TestError()
        {
            int x = 10;
            int y = 0;
            int d = x / y;
            return Content(d.ToString());
        }

        public IActionResult Error()
        {
            return View();
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
