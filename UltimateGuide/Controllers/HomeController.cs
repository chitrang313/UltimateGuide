using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
            if (!ModelState.IsValid) {
               string errors = string.Join(Environment.NewLine, ModelState.Values.SelectMany(item => item.Errors.Select(error => error.ErrorMessage)));
                
                return BadRequest(errors);
            }

            return Content($"{person}","text/plain");
        }
    }
}
