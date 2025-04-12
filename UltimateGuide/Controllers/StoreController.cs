using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class StoreController:Controller {
        [Route("store/books/{id}")]
        public IActionResult Books() {
            int _bookId = Convert.ToInt32(Request.RouteValues["id"]);
            return Content($"<h1>Book: {_bookId}</h1>","text/html");
        }
    }
}
