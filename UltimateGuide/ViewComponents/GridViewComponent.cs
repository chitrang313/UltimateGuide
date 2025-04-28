using Microsoft.AspNetCore.Mvc;

namespace UltimateGuide.ViewComponents {
    [ViewComponent]
    public class GridViewComponent : ViewComponent{
        Task<IViewComponentResult> InvokAsync() {
            return View(); //invoke partial view path: "Views/Shared/Components/Grid/Default.cshtml"
        }
    }
}
