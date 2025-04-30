using Microsoft.AspNetCore.Mvc;
using Services;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        private readonly CitiesServices _citiesServices;
        public HomeController() {
            _citiesServices = new CitiesServices();
        }

        [Route("/")]
        public IActionResult Index() {
            List<string> _cityList = _citiesServices.GetCities();
            return View(_cityList);
        }
    }
}
