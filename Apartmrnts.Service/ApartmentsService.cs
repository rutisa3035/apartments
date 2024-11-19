using Apartments.Core.Repositories;
using Apartments.Core.Services;
using Apartments.Data.Repositories;
using Apartments.Entitise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartmrnts.Service
{
    public class ApartmentsService: IApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;

        public ApartmentsService(IApartmentRepository apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }
        public List<apartment> GetList()
        {
            return _apartmentRepository.GetAll();
        }
    }
}
