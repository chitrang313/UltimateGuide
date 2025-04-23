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
     new Person { PersonName = "John Doe", Gender = Gender.Male,DateofBirth = DateTime.Parse("1994-10-18")  },
     new Person { PersonName = "Jane Smith", Gender = Gender.Female,DateofBirth = DateTime.Parse("2025-04-17")  },
     new Person { PersonName = "Sam Brown",Gender = Gender.Other, DateofBirth = DateTime.Parse("2025-04-18") }
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
     new Person { PersonName = "John Doe", Gender = Gender.Male,DateofBirth = DateTime.Parse("1994-10-18")  },
     new Person { PersonName = "Jane Smith", Gender = Gender.Female,DateofBirth = DateTime.Parse("2025-04-17")  },
     new Person { PersonName = "Sam Brown",Gender = Gender.Other, DateofBirth = DateTime.Parse("2025-04-18") }
 };
            Person? person = persons.Where(p => p.PersonName.ToLower() == name.ToLower()).FirstOrDefault();
            return View("Details",person);
        }

        [HttpGet]
        [Route("person-with-products")]
        public IActionResult PersonWithProducts() {
            ViewBag.Title = "Person with Products";
            Person person = new Person() {
                PersonName = "Ram",
                Gender = Gender.Male,
                DateofBirth = DateTime.Parse("1994-10-18"),
            };
            Product product = new Product() {
                ProductId = 1,
                ProductName = "KitKat"
            };
            PersonWithProductsModel personWithProducts = new PersonWithProductsModel() {
                PersonData = person,
                ProductData = product
            };
            return View("PersonWithProducts", personWithProducts);
        }

        [Route("home/all-products")]
        public IActionResult All() { 
            return View();
            //Views/Home/All
            //Views/Shared/All <--- mostly this is used for partial view
        }
    }
}
