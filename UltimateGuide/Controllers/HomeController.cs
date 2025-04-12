using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using UltimateGuide.Models;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("bookstore/{bookid?}/{isloggedin?}")]
        public IActionResult Index(int? bookid, bool? isloggedin, Book book) {
            if (!bookid.HasValue) {
                //Response.StatusCode = 400;
                //return Content("Book ID is empty");
                return BadRequest("Book ID is not supplied or empty");
            }

            if (bookid <= 0 || bookid > 1000) {
                //return Content("Book ID must be greter then zero and less then 1000");
                return NotFound("Book ID must be greater than zero and less than 1000");
            }

            if (isloggedin.HasValue && !Convert.ToBoolean(isloggedin)) {
                //Response.StatusCode = 401;
                //return Content("You must be logged in to view this page");
                return Unauthorized("You must be logged in to view this page");
            }
            //return File("sample.pdf","application/pdf");

            //302 - Temporary Redirect
            //return new RedirectToActionResult("Books", "Store", new { });
            return RedirectToAction("Books","Store",new { id = bookid });

            //301 - Permanent Redirect
            //return new RedirectToActionResult("Books", "Store", new { },permanent: true);
            //return RedirectToActionPermanent("Books","Store",new { id = bookid });

            //302 - Temporary Redirect
            //LocalRedirectResult we are using for locally redirect using url
            //return new LocalRedirectResult($"store/books/{bookid}");
            //return LocalRedirect($"store/books/{bookid}");

            //301 - Permanent Redirect
            //return new LocalRedirectResult($"store/books/{bookid}",permanent: true);
            //return LocalRedirectPermanent($"store/books/{bookid}");

            //return Redirect($"store/books/{bookid}");
            //return RedirectPermanent($"/store/books/{bookid}");
        }
    }
}
