using Apartments.Core.Repositories;
using Apartments.Core.Services;
using Apartments.Entitise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartmrnts.Service
{
    public class BrokerService: IBrokerService
    {
        private readonly IBrokerRepository _brokerRepository;

        public BrokerService(IBrokerRepository brokerRepository)
        {
            _brokerRepository = brokerRepository;
        }
        public List<Broker> GetList()
        {
            return _brokerRepository.GetAll();
        }
    }
}
