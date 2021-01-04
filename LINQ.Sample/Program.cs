using System;
using System.Collections.Generic;

namespace LINQ.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add Motorycles to List

            List<Motorcycle> motorcyles = new List<Motorcycle>();
            motorcyles.Add(new Motorcycle { Model = "Minsk X250", Odometer = 25_100 });
            motorcyles.Add(new Motorcycle { Model = "Minsk X250", Odometer = 25_100 });
            motorcyles.Add(new Motorcycle { Model = "Minsk X250", Odometer = 25_100 });
            motorcyles.Add(new Motorcycle { Model = "Minsk X250", Odometer = 25_100 });
            motorcyles.Add(new Motorcycle { Model = "Minsk X250", Odometer = 25_100 });
        }
    }
}
