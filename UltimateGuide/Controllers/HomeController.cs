using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace UltimateGuide.Controllers {
    public class HomeController:Controller {
        private readonly ICityServices _citiesService1;
        private readonly ICityServices _citiesService2;
        private readonly ICityServices _citiesService3;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public HomeController(ICityServices citiesService1,
            ICityServices citiesService2,
            ICityServices citiesService3,
            IServiceScopeFactory serviceScopeFactory) {
            _citiesService1 = citiesService1;
            _citiesService2 = citiesService2;
            _citiesService3 = citiesService3;
            _serviceScopeFactory = serviceScopeFactory;
        }

        [Route("/")]
        public IActionResult Index() {
            List<string> _cityList = _citiesService1.GetCities();

            ViewBag.InstanceIdCityServices1 = _citiesService1.ServiceInstanceId;
            ViewBag.InstanceIdCityServices2 = _citiesService2.ServiceInstanceId;
            ViewBag.InstanceIdCityServices3 = _citiesService3.ServiceInstanceId;

            using (IServiceScope scope = _serviceScopeFactory.CreateScope()) {
                //Inject City service
                ICityServices cityServices = scope.ServiceProvider.GetRequiredService<ICityServices>();
                //DB work
                ViewBag.InstanceId_CityServices = cityServices.ServiceInstanceId;

            }//end of the scope; it calls CitydService.Dispose() method of the service
            return View(_cityList);
        }
    }
}
