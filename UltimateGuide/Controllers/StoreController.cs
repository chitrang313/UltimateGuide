using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class StoreController:Controller {
        [Route("store/books")]
        public string Books() {
            return "Book Store";
        }
    }
}
