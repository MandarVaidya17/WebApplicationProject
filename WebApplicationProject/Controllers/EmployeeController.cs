using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationProject.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            List<string> cities = new List<string>()
            {
                "Pune","Mumbai","Nashik","Akole"
            };
            ViewData["cities"] = new SelectList(cities);
            List<string> dept = new List<string>()
            {
                "Devloper","QA","HR","Production"
            };
            ViewData["dept"]=new SelectList(dept);
            return View();
        }
        [HttpPost]

        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Email = form["email"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["cities"];
            ViewBag.Dept = form["dept"];
            ViewBag.Qul = form["qulification"];
            return View("DisplayEmp");
        }
    }
}
