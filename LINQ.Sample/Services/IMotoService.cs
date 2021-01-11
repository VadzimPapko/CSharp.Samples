using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Sample.Services
{
    interface IMotoService
    {
        List<Motorcycle> Where( IEnumerable<Motorcycle> motorcycles, 
                                                                     Func<int, bool> motorcycleDelegate);
    }
}
