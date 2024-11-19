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
    public class PatientService : IPatientService

    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public List<patient> GetList()
        {
            return _patientRepository.GetAll();
        }
    }
}
