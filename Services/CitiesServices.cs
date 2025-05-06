using ServiceContracts;

namespace Services {
    public class CitiesServices:ICityServices {
        private Guid _serviceInstanceId;
        public Guid ServiceInstanceId {
            get {
                return _serviceInstanceId;
            }
        }
        private List<string> _cityList;
        public CitiesServices() {
            _serviceInstanceId = Guid.NewGuid();
            _cityList = new List<string>() {
                "London",
                "New York",
                "Tokyo",
                "Paris",
            };
        }

        public List<string> GetCities() {
            return _cityList;
        }
    }
}
