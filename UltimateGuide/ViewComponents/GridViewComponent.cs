using Microsoft.AspNetCore.Mvc;
using UltimateGuide.Models;

namespace UltimateGuide.ViewComponents {
    public class GridViewComponent:ViewComponent {
        public async Task<IViewComponentResult> InvokeAsync() {
            PersonGridModel personGridModel = new PersonGridModel() {
                GridTitle = "Persons List",
                Persons = new List<Person>() {
                new Person(){
                    PersonName = "Chitrang",
                    PersonJobTitle = "Software Engineer"
                },
                new Person(){
                    PersonName = "User",
                    PersonJobTitle = "Data Analitics Engineer"
                },
                }
            };
            return View("Sample",personGridModel);
        }
    }
}
