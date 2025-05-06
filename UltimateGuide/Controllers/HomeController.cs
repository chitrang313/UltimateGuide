using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        private readonly ICityServices _citiesService1;
        private readonly ICityServices _citiesService2;
        private readonly ICityServices _citiesService3;

        public HomeController(ICityServices citiesService1,ICityServices citiesService2,ICityServices citiesService3) {
            _citiesService1 = citiesService1;
            _citiesService2 = citiesService2;
            _citiesService3 = citiesService3;
        }

        [Route("/")]
        public IActionResult Index() {
            List<string> _cityList = _citiesService1.GetCities();

            ViewBag.InstanceIdCityServices1 = _citiesService1.ServiceInstanceId;
            ViewBag.InstanceIdCityServices2 = _citiesService2.ServiceInstanceId;
            ViewBag.InstanceIdCityServices3 = _citiesService3.ServiceInstanceId;

            return View(_cityList);
        }
    }
}
