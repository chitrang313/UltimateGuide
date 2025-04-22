using Microsoft.AspNetCore.Mvc;
using UltimateGuide.Models;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("home")]
        [Route("/")]
        public IActionResult Index() {
            ViewData["Title"] = "asp.net core ultimate guid";
            List<Person> persons = new List<Person>
             {
     new Person { Name = "John Doe", Gender = Gender.Male,DateofBirth = DateTime.Parse("1994-10-18")  },
     new Person { Name = "Jane Smith", Gender = Gender.Female,DateofBirth = DateTime.Parse("2025-04-17")  },
     new Person { Name = "Sam Brown",Gender = Gender.Other, DateofBirth = DateTime.Parse("2025-04-18") }
 };
            //ViewData["Persons"] = persons;
            ViewBag.Persons = persons;
            return View();
        }
    }
}
