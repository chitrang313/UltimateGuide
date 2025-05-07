using ServiceContracts;

namespace Services {
    public class CitiesServices:ICityServices, IDisposable {
        private List<string> _cities;
        private Guid _servieInstanceId;

        public Guid ServiceInstanceId {
            get {
                return _servieInstanceId;
            }
        }

        public CitiesServices() {
            _servieInstanceId = Guid.NewGuid();
            _cities = new List<string>() {
        "London",
        "Paris",
        "New York",
        "Tokyo",
        "Rome"
      };

            //TODO: Add logic to open database connection
        }

        public List<string> GetCities() {
            return _cities;
        }

        public void Dispose() {
            //TODO: add logic to close database connection
        }
    }
}
