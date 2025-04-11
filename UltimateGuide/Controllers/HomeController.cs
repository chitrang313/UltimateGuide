using Microsoft.AspNetCore.Mvc;
using UltimateGuide.Models;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("file")]
        [HttpPost]
        public IActionResult Index() {
            if (!Request.Query.ContainsKey("bookid")) {
                //Response.StatusCode = 400;
                //return Content("Book ID not provided");
                //return new BadRequestResult();
                return BadRequest("Book ID not provided");
            }

            if (string.IsNullOrWhiteSpace((string)Request.Query["bookid"])) {
                //Response.StatusCode = 400;
                //return Content("Book ID is empty");
                return BadRequest("Book ID is empty");
            }

            int bookId = Convert.ToInt32(Request.Query["bookid"]);
            if (bookId <= 0 || bookId > 1000) {
                //return Content("Book ID must be greter then zero and less then 1000");
                return NotFound("Book ID must be greater than zero and less than 1000");
            }
            bool isLoggedIn = Convert.ToBoolean(Request.Query["isloggedin"]);
            if (!isLoggedIn) {
                //Response.StatusCode = 401;
                //return Content("You must be logged in to view this page");
                return Unauthorized("You must be logged in to view this page");
            }
            return File("sample.pdf","application/pdf");
        }

    }
}
