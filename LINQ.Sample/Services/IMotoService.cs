using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Sample.Services
{
    interface IMotoService
    {
        List<Motorcycle> Where<T, TResult>( IEnumerable<Motorcycle> motorcycles, 
                                                                     Func<T, TResult> motorcycleDelegate);
    }
}
