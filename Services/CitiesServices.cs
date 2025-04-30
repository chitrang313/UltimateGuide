namespace Services {
    public class CitiesServices {
        private List<string> _cityList;
        public CitiesServices() {
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
