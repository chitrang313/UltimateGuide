using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("sayhello")]
        [Route("/")]
        public ContentResult Index() {
            //return new ContentResult() {
            //    ContentType = "text/plain",
            //    Content = "Hello from the Home Controller",
            //};

            //return Content("Hello from the Home Controller","text/plain");

            return Content("<h1>Hello</h1><h3>from the html</h3>", "text/html");
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
