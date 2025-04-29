using Microsoft.AspNetCore.Mvc;
using UltimateGuide.Models;

namespace UltimateGuide.ViewComponents {
    public class GridViewComponent:ViewComponent {
        public async Task<IViewComponentResult> InvokeAsync(PersonGridModel gridModel){
            return View("Sample",gridModel);
        }
    }
}
