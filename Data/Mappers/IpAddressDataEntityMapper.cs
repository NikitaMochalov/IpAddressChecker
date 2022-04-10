using Data.Entities;
using Domain.Entities;
using Domain.Mappers;

namespace Data.Mappers
{
    public class IpAddressDataEntityMapper: IMapper<IpAddressData, IpAddressEntity>
    {
        public IpAddressEntity MapFrom(IpAddressData input)
        {
            if (input == null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            return new IpAddressEntity
            {
                Country = input.Country,
                City = input.City,
                Latitude = input.Latitude,
                Longitude = input.Longitude,
                InternetProvider = input.InternetProvider
            };
        }
    }
}
