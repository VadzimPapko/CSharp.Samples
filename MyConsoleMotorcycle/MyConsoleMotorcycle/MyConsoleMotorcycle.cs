using System;
using System.Collections.Generic;
using System.Text;

namespace MyConsoleMotorcycle
{
    class MyConsoleMotorcycle
    {
        public string Model { get; set; }

        public static int Odometer { get; private set; }

        public int DailyDistance { get; set; }

        public MyConsoleMotorcycle(string model)
        {
            Model = model;
        }

        public void StartEngine() 
        {
            Console.WriteLine();
            Console.WriteLine("Engine started.");
        }

        public void Move(int distance) 
        {
            DailyDistance += distance;
            Console.WriteLine($"Move to {distance}km.");
        }

        public void StopEngine() 
        {
            Odometer += DailyDistance;

            //Send Odometr to Global Motorcycle Service.
            //Ideally it should be a Data Base, for instance
            GlobalMotorcycleServiceModule.MotorcyleService.TotalDistance = Odometer;

            Console.WriteLine("Engine stopped.");
            Console.WriteLine($"TotalDistance: {Odometer}km.");
        }

    }
}
