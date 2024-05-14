using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationProject.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Page1()
        {
            List<string> cities = new List<string>()
            {
                "Pune","mumbai","Nashik","akole"
            };
            ViewData["cities"] = new SelectList(cities);//iterate the elements $ single selection
            ViewData["city"]=new MultiSelectList(cities);//iterate the element & allow multiple selection
            return View();
        }
        
    }
}
