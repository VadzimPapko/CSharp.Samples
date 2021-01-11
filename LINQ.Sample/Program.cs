using System;
using System.Collections.Generic;
using LINQ.Sample.Services;

namespace LINQ.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add Motorycles to List

            List<Motorcycle> motorcyles = new List<Motorcycle>();
            motorcyles.Add(new Motorcycle { Model = "Minsk X250", Odometer = 25_100 });
            motorcyles.Add(new Motorcycle { Model = "Honda", Odometer = 20_100 });
            motorcyles.Add(new Motorcycle { Model = "Ducati", Odometer = 125_100 });
            motorcyles.Add(new Motorcycle { Model = "Yamaha", Odometer = 525_100 });
            motorcyles.Add(new Motorcycle { Model = "Ural", Odometer = 1_100 });

            MotoService motoService = new MotoService();
            MotorcycleDelegate motorcycleDelegate = ShouldGoToService;
            var filteredMotorcycles = motoService.Where(motorcyles, motorcycleDelegate);
        }

        static bool ShouldGoToService(int odometer) 
        {
            return odometer > 25_000;
        }
    }
}
