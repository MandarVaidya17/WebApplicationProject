using Microsoft.AspNetCore.Mvc;
using WebApplicationProject.Models;

namespace WebApplicationProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            return View();
        }

    }
}
