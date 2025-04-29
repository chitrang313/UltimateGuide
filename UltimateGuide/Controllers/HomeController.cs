using Microsoft.AspNetCore.Mvc;
using UltimateGuide.Models;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        [Route("/")]
        public IActionResult Index() {
            return View();
        }
        [Route("/about")]
        public IActionResult About() {
            return View();
        }

        [Route("friends-list")]
        public IActionResult FriendList() {
            PersonGridModel friendsGridModel = new PersonGridModel() {
                GridTitle = "Friends List",
                Persons = new List<Person>() {
                new Person(){
                    PersonName = "friend one",
                    PersonJobTitle = "Devops Engineer"
                },
                new Person(){
                    PersonName = "friend two",
                    PersonJobTitle = "AIML Engineer"
                },
                }
            };
            return ViewComponent("Grid",friendsGridModel);
        }
    }
}
