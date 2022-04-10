namespace Domain.Entities
{
    public class IpAddressEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string InternetProvider { get; set; }
    }
}
