using Microsoft.AspNetCore.Mvc;
using WebApplicationProject.Models;

namespace WebApplicationProject.Controllers
{
    public class BookController : Controller
    {
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddBook(Book book)
        {
            return View();
        }
    }
}
