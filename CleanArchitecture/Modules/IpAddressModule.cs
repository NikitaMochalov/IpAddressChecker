using Data.Api;
using Data.Entities;
using Data.Mappers;
using Data.Repository;
using Domain.Entities;
using Domain.Mappers;
using Domain.Repository;
using Domain.UseCases;
using Ninject.Modules;

namespace CleanArchitecture.Modules
{
    public class IpAddressModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper<IpAddressData, IpAddressEntity>>().To<IpAddressDataEntityMapper>();
            Bind<IIpApi>().To<IpApi>();
            Bind<IRepository>().To<IpAddressRepository>();
            Bind<GetIpAddressInteractor>().ToSelf().InSingletonScope();
        }
    }
}
