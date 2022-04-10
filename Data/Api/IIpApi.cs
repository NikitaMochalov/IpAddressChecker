using Data.Entities;

namespace Data.Api
{
    public interface IIpApi
    {
        IpAddressData GetIpData(string ip);
    }
}
