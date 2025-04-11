using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("sayhello")]
        [Route("/")]
        public string Index() {
            return "Hello from the Index of Home";
        }

        [Route("about")]
        public string About() {
            return "Hello from the About of Home";
        }

        [Route("contact-us")]
        [Route("contact/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact() {
            return "Hello from the Contact of Home";
        }
    }
}
