using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("sayhello")]
        public string Index() {
            return "Hello from the Index of Home";
        }
    }
}
