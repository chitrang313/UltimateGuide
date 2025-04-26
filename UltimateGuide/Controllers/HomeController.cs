using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("/")]
        public IActionResult Index() {
            ViewData["Title"] = "Cities";
            ViewData["ListItems"] = new List<string> { "New York","Los Angeles","Chicago","Houston","Phoenix" };

            return View();
        }

        [Route("about")]
        public IActionResult About() {
            return View();
        }
    }
}
