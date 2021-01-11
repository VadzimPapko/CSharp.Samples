using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Sample.Services
{
    class MotoService : IMotoService
    {
        /*
        public List<Motorcycle> Where(IEnumerable<Motorcycle> motorcycles, MotorcycleDelegate motorcycleDelegate)
        {
            var result = new List<Motorcycle>();
            if (motorcycleDelegate == null) return result;

            foreach (var moto in motorcycles)
                if (motorcycleDelegate(moto.Odometer))
                    result.Add(moto);

            return result;
        }
        */

        public List<Motorcycle> Where(IEnumerable<Motorcycle> motorcycles, Func<int, bool> motorcycleDelegate)
        {
            var result = new List<Motorcycle>();
            if (motorcycleDelegate == null) return result;

            foreach (var moto in motorcycles)
                if (motorcycleDelegate(moto.Odometer))
                    result.Add(moto);

            return result;
        }
    }
}
