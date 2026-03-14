using Microsoft.AspNetCore.Mvc;
using MVCProject1.Data;

namespace MVCProject1.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository _repo;

        public StudentController(StudentRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var students = _repo.GetAllStudents();
            return View(students);
        }
    }
}
