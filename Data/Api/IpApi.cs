using System;
using System.Configuration;
using Data.Entities;
using Newtonsoft.Json;
using RestSharp;

namespace Data.Api
{
    public class IpApi: IIpApi
    {
        private readonly RestClient _client = new RestClient("http://ip-api.com/json");

        public IpApi() { }

        public IpAddressData GetIpData(string ip)
        {
            if (ip == null)
            {
                throw new ArgumentNullException(nameof(ip));
            }

            var request = new RestRequest("{ipAdress}", Method.GET); 
            request.AddUrlSegment("ipAdress", ip);

            var response = _client.Execute(request);

            return JsonConvert.DeserializeObject<IpAddressData>(response.Content);
        }
    }
}
