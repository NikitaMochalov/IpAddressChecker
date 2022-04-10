using Domain.Entities;

namespace Domain.Repository
{
    public interface IRepository
    {
        IpAddressEntity GetIp(string ipAdress);
    }
}
