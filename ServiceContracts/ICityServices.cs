namespace ServiceContracts {
    public interface ICityServices {
        Guid ServiceInstanceId { get;}
        List<string> GetCities();
    }
}
