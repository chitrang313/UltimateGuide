using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using UltimateGuide.Models;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {

        [Route("/")]
        public IActionResult Index() {
            return Content("<h1>Home Page</h1>","text/html");
        }

        [Route("register")]
        public IActionResult Register(Person person) {
            return Content($"{person}","text/plain");
        }
    }
}
