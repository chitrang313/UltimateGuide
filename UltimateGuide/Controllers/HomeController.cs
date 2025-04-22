using Microsoft.AspNetCore.Mvc;
using UltimateGuide.Models;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("home")]
        [Route("/")]
        public IActionResult Index() {
            ViewBag.Title = "asp.net core ultimate guid";
            List<Person> persons = new List<Person>
             {
     new Person { Name = "John Doe", Gender = Gender.Male,DateofBirth = DateTime.Parse("1994-10-18")  },
     new Person { Name = "Jane Smith", Gender = Gender.Female,DateofBirth = DateTime.Parse("2025-04-17")  },
     new Person { Name = "Sam Brown",Gender = Gender.Other, DateofBirth = DateTime.Parse("2025-04-18") }
 };
            return View("Index",persons);
        }

        [HttpGet]
        [Route("person-details/{name}")]
        public IActionResult Details(string? name) {
            if (string.IsNullOrWhiteSpace(name)) {
                return Content("Name can not be null or empty");
            }
            ViewBag.Title = "Person Details";
            List<Person> persons = new List<Person>
             {
     new Person { Name = "John Doe", Gender = Gender.Male,DateofBirth = DateTime.Parse("1994-10-18")  },
     new Person { Name = "Jane Smith", Gender = Gender.Female,DateofBirth = DateTime.Parse("2025-04-17")  },
     new Person { Name = "Sam Brown",Gender = Gender.Other, DateofBirth = DateTime.Parse("2025-04-18") }
 };
            Person? person = persons.Where(p => p.Name.ToLower() == name.ToLower()).FirstOrDefault();
            return View("Details",person);
        }
    }
}
