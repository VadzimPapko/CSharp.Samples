using GlobalMotorcycleServiceModule;
using System;

namespace MyConsoleMotorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            //MotoServiceDelegate @delegate = new MotoServiceDelegate(GoToService); //Fisrt Option to Initialize a delegate instance


            /* Sample with non-static methods
            Program program = new Program();
            MotoServiceDelegate @delegate = program.SendPushNotification;   //Second Option to Init a delegate instance
            */

            MotoServiceDelegate @delegate = GoToService;   //Second Option to Init a delegate instance
            @delegate += GoToServiceViaEmail;
            Program program = new Program();
            @delegate += program.SendPushNotification;
            //Delegate.Combine(@delegate, @delegate);


            //Day One
            MyConsoleMotorcycle myConsoleMotorcycle = new MyConsoleMotorcycle("Honda CB600F");
            MotorcyleService motorcyleService = new MotorcyleService(@delegate);

            //just extra stuff
            //if (motorcyleService.ShouldINotify) 
            //{
            //    GoToService(MotorcyleService.TotalDistance);
            //}

            myConsoleMotorcycle.StartEngine();
            myConsoleMotorcycle.Move(1_000);
            myConsoleMotorcycle.Move(5_000);
            myConsoleMotorcycle.StopEngine();
            myConsoleMotorcycle = null;
            motorcyleService = null;

            //Day Two
            myConsoleMotorcycle = new MyConsoleMotorcycle("Honda CB600F");
            motorcyleService = new MotorcyleService(@delegate);
            myConsoleMotorcycle.StartEngine();
            myConsoleMotorcycle.Move(1_000);
            myConsoleMotorcycle.Move(3_000);
            myConsoleMotorcycle.StopEngine();
            myConsoleMotorcycle = null;
            motorcyleService = null;

            //Day Three
            myConsoleMotorcycle = new MyConsoleMotorcycle("Honda CB600F");

            @delegate -= GoToService;
            @delegate -= GoToServiceViaEmail;
            @delegate -= program.SendPushNotification;

            motorcyleService = new MotorcyleService(@delegate);
            myConsoleMotorcycle.StartEngine();

        }

        static void GoToService(int currentDistance) 
        {
            Console.WriteLine($"Time to go moto Service. Current distance of your bike: {currentDistance}");
        }

        static void GoToService(string motoName) { }

        static void GoToServiceViaEmail(int currentDistance) 
        {
            Console.WriteLine("Email Sent");
            //create SMTP object top send an email;
        }

        void SendPushNotification(int currentDistance) 
        {
          //Send Push notification
        }
    }
}
