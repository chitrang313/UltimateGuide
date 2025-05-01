using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        private readonly ICityServices _citiesServices;
        public HomeController() {
            _citiesServices = null;//new CitiesServices();
        }

        [Route("/")]
        public IActionResult Index() {
            List<string> _cityList = _citiesServices.GetCities();
            return View(_cityList);
        }
    }
}
