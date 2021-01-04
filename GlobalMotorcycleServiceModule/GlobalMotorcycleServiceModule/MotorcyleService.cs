using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalMotorcycleServiceModule
{
    public delegate void MotoServiceDelegate(int totalDistance); 
    
    /// <summary>
    /// Global Motorcycle Service that veryfies the total
    /// siatance of a motorcycle. If that one either more 
    /// or equals than 10_000 it will notify a end user via
    /// the message.
    /// </summary>
    public class MotorcyleService
    {
        private MotoServiceDelegate _motoServiceDelegate;

        public static int TotalDistance { get; set; }

        public bool ShouldINotify { get; set; }

        public MotorcyleService(MotoServiceDelegate motoServiceDelegate)
        {
            _motoServiceDelegate = motoServiceDelegate;
            CheckDistance();
        }

        void CheckDistance() 
        {
            if (TotalDistance >= 10_000)
            {
                //ShouldINotify = true;
                NotifyAboutService();
            }
        }

        void NotifyAboutService() 
        {
            //Notify End User
            _motoServiceDelegate?.Invoke(TotalDistance); //first option

            if (_motoServiceDelegate == null) return;
            
            _motoServiceDelegate(TotalDistance); //second option to invoke a Delegate
        }
    }
}
