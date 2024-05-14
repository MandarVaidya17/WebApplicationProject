﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationProject.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonDetails()
        {
            List<string> cities = new List<string>()
            {
                "Pune","mumbai","Nashik","akole"
            };
            ViewData["cities"] = new SelectList(cities);
            return View();
        }
        [HttpPost]

        public IActionResult PersonDetails(IFormCollection form)
        {

            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.Email = form["email"]; 
            ViewBag.City= form["cities"];
            return View("Print");
        }
    }
}
