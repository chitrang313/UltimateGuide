using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.Controllers {
    public class ProductController:Controller {
        [Route("products")]
        public IActionResult Index() {
            return View();
        }

        //url: search/11
        [Route("search/{productId?}")]
        public IActionResult Search(int? productId) {
            ViewBag.productId = productId;
            return View();
        }

        [Route("order")]
        public IActionResult Order() {
            return View();
        }
    }
}
