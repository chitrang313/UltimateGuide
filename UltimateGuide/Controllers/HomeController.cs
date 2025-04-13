using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("home")]
        public IActionResult Index() {
            return View();
        }
    }
}
