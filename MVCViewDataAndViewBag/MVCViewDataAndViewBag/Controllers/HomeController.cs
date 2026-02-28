using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCViewDataAndViewBag.Models;

namespace MVCViewDataAndViewBag.Controllers
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
        public IActionResult Member()
        {
            ViewData["Name"] = "karan";
            ViewData["College"] = "LPU";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
