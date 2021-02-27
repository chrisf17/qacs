using System;

namespace Exercise20.Events
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            // 1. Build and Run. Why doesn't it display the speed? Look in AccelerateToMaxSpeed
            //    If we put Console.WriteLine in AccelerateToMaxSpeed we are assuming we know how all users want to
            //    display or use the speed when it changes
            // 2. Goto the Car class and follow steps
            // 6. Handle SpeedChanged event and run Car_SpeedChanged method
            //    when SpeedChanged event fires
            // 7. Build and Run. We should see the Car speed displayed as it accelerates
            // If you have time
            // 8. Handle event using a lambda rather than Car_SpeedChanged method
            // 9. Try rewriting Car to use the generic EventHandle<> and create
            //    a custom SpeedChangedEventArgs that has a Speed property
            //    Car_Generic.cs has the solution if you would like hints
            Accelerator.AccelerateToMaxSpeed(myCar);
        }

        static void Car_SpeedChanged(object sender, EventArgs args)
        {
            Car theCar = sender as Car; // sender of event should be a Car
            Console.WriteLine($"Speed:{theCar.Speed}");

        }
    }
}
