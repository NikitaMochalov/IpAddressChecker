using System;
using Domain.Entities;
using Domain.Repository;

namespace Domain.UseCases
{
    public class GetIpAddressInteractor: IRequestHandler<string,IpAddressEntity>
    {
        private readonly IRepository _repository;

        public GetIpAddressInteractor(IRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        public IpAddressEntity Handle(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            return _repository.GetIp(data);
        }
    }
}
