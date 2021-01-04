using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Sample.Services
{
    class MotoService : IMotoService
    {
        public List<Motorcycle> Where(IEnumerable<Motorcycle> motorcycles, MotorcycleDelegate motorcycleDelegate)
        {
            throw new NotImplementedException();
        }
    }
}
