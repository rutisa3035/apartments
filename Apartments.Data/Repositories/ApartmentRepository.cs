using Apartments.Core.Repositories;
using Apartments.Entitise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments.Data.Repositories
{
    public class ApartmentRepository: IApartmentRepository
    {
        private readonly DataContext _context;

        public ApartmentRepository(DataContext context)
        {
            _context = context;
        }

        public List<apartment> GetAll()
        {
            return _context.apartment;
        }
    }
}
