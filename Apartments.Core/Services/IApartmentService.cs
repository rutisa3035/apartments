using Apartments.Entitise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments.Core.Services
{
    public interface IApartmentService
    {
        public List<apartment> GetList();
    }
}
