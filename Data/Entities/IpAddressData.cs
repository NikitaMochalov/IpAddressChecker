using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Data.Entities
{
    public class IpAddressData
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lon")]
        public float Longitude { get; set; }

        [JsonProperty("isp")]
        public string InternetProvider { get; set; }
    }
}
