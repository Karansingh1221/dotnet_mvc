using Microsoft.AspNetCore.Mvc;


namespace MVCProject2.Controllers
{
    public class StudentController:Controller
    {
        public IActionResult Recieve()
        {
            var a = TempData["a"];
            var b = TempData["b"];
            var msg = a;
            return Content(msg?.ToString());
        }
        public IActionResult RecieveNumber()
        {
            int x = (int)TempData["x"];
            return Content((x * x).ToString());

        }

    }
}
