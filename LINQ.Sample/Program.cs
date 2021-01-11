using System;
using System.Collections.Generic;
using System.Linq;
using LINQ.Sample.Services;
using System.Linq;

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
            //MotorcycleDelegate motorcycleDelegate = ShouldGoToService;

            //Func<int, bool> motorcycleDelegate = ShouldGoToService;

            int localOdometer = 25_000; //Read a databese to get this values, for instance

            //Func<int, bool> motorcycleDelegate = delegate (int odometer) { return odometer > localOdometer; };
            //var filteredMotorcycles = motoService
            //    .Where(motorcyles, delegate (int odometer) { return odometer > localOdometer; });

            //Lambda Expresiion Sample
            //Func<int, bool> motorcycleDelegate = (odometer) => (odometer > localOdometer);
            Func<int, bool> motorcycleDelegate = _ => _ > localOdometer;

            Func<int, DateTime, string> @delegate = ShouldGoToService;
            var filteredMotorcycles = motoService
                .Where(motorcyles, delegate (int odometer) { return odometer > localOdometer; });

            var linqCollection = motorcyles.Where(m => m.Odometer > 25_000); //LINQ Fluet Syntax

            //LINQ Query Syntax
            var linqCollection2 =   from m in motorcyles
                                                where m.Odometer > 25_000
                                                select new { Name = m.Model };

            var linqCollection3 = motorcyles
                .Where(m => m.Model.Contains("a"))
                .Skip(2)
                .OrderBy(m => m.Odometer)
                .Select(m => new { Name = m.Model, Odometer = m.Odometer });

            var result = linqCollection3.Any();
            var first = linqCollection3.First(_ => _.Odometer > 100_000);
            var firstOrDefault = linqCollection3.FirstOrDefault();

            //HW difference beetwen Fisrt and FirstOrDefault, Single, SingleOrDefault
        }

        static bool ShouldGoToService(int odometer) 
        {
            return odometer > 25_000;
        }

        static string ShouldGoToService(int arg1, DateTime time)
        {
            return string.Empty;
        }
    }
}
