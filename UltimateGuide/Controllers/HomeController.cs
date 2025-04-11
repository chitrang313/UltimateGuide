using Microsoft.AspNetCore.Mvc;
using UltimateGuide.Models;

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

        [Route("person")]
        public JsonResult Person() {
            Person person = new Person() {
                Id = Guid.NewGuid(),
                firstName = "username",
                lastName = "surname",
                age = 30,
            };
            //return new JsonResult(person);
            return Json(person);
        }

        [Route("file-download")]
        public VirtualFileResult DownloadFile() {
            //return new VirtualFileResult("/sample.pdf","application/pdf");
            return File("/sample.pdf","application/pdf");
        }
        
        //D:\Web\Placeholders
        [Route("file-download-2")]
        public PhysicalFileResult DownloadFilePhysically() {
            //return new PhysicalFileResult(@"D:/Web/Placeholders/sample.pdf","application/pdf");
            return PhysicalFile(@"D:/Web/Placeholders/sample.pdf","application/pdf");
        }

        [Route("file-download-3")]
        public FileContentResult DownloadFileContent() {
            byte[] bytes = System.IO.File.ReadAllBytes(@"D:/Web/Placeholders/sample.pdf");
            //return new FileContentResult(bytes,"application/pdf");
            return File(bytes,"application/pdf");
        }

        [Route("contact-us")]
        [Route("contact/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact() {
            return "Hello from the Contact of Home";
        }
    }
}
