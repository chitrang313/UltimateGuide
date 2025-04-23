using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("/")]
        public IActionResult Index() {
            return View();
        }

        [Route("about")]
        public IActionResult About() {
            return View();
        }

        [Route("contact-us")]
        public IActionResult Contact() {
            return View();
        }
    }
}
