using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.ViewComponents {
    public class GridViewComponent : ViewComponent{
        public async Task<IViewComponentResult> InvokeAsync() { 
            return View("Sample");
        }
    }
}
