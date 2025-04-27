using Microsoft.AspNetCore.Mvc;
using UltimateGuide.Models;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("/")]
        public IActionResult Index() {
            return View();
        }

        [Route("about")]
        public IActionResult About() {
            return View();
        }

        [Route("programming-language")]
        public IActionResult ProgramingLanguage() {
            ListItems listItems = new ListItems();
            listItems.ItemName = "Programming Language";
            listItems.ItemsList.Add("C#");
            listItems.ItemsList.Add("Java");
            listItems.ItemsList.Add("Python");

            return PartialView("_ListPartialView", listItems);
        }
    }
}
