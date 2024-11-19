using Apartments.Core.Repositories;
using Apartments.Entitise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments.Data.Repositories
{
    public class BrokerRepository: IBrokerRepository
    {
        private readonly DataContext _context;

        public BrokerRepository(DataContext context)
        {
            _context = context;
        }

        public List<Broker> GetAll()
        {
            return _context.Broker;
        }

    }
}
