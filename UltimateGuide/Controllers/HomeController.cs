using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("home")]
        [Route("/")]
        public IActionResult Index() {
            return View();
        }
    }
}
