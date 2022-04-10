using System;
using Data.Api;
using Data.Entities;
using Domain.Entities;
using Domain.Mappers;
using Domain.Repository;

namespace Data.Repository
{
    public class IpAddressRepository: IRepository
    {
        private readonly IIpApi _api;
        private readonly IMapper<IpAddressData, IpAddressEntity> _mapper;

        public IpAddressRepository(IIpApi api,IMapper<IpAddressData, IpAddressEntity> mapper)
        {
            _api = api ?? throw new ArgumentNullException(nameof(api));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        public IpAddressEntity GetIp(string ipAdress)
        {
            if (string.IsNullOrEmpty(ipAdress))
            {
                throw new ArgumentNullException(nameof(ipAdress));
            }

            return _mapper.MapFrom(_api.GetIpData(ipAdress));
        }
    }
}
