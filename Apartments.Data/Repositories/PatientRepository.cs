using Apartments.Core.Repositories;
using Apartments.Entitise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments.Data.Repositories
{
    public class PatientRepository :IPatientRepository
    {
        private readonly DataContext _context;

        public PatientRepository(DataContext context)
        {
            _context = context;
        }
        
        public List<patient> GetAll()
        {
            return _context.patient;
        }
    }
}
