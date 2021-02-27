using System;
// Comment/Uncomment one of Starter or Solution
using Exercise9.Inheritance.Starter;
//using Exercise9.Inheritance.Solution;
namespace Exercise9.Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Step1();
            //Step2();
        }


        static void Step1()
        {
            // 1. Make Car, Van and Truck inherit from Vehicle
            // 2. Move all the things Car, Van and Truck have in common up to Vehicle
            //    This will include Make, Model, Registration
            //     Check Solution folder to make sure you are right.
            //     Remember DRY - Do not Repeat Yourself
            // 3. In DVLA class there are specific methods to register each Vehicle
            //    Uncomment RegisterVehicle it should not error
            // 4. Remove or comment out RegisterVam, RegisterCar, RegisterTruck methods

            var van = new Van() { Make = "Ford", Model = "Transit" };

            // 5. Change call to DVLA.RegisterVehicle(van)
            //    Because of inheritance any of the vehicles Car, Van or Truck can be passed to RegisterVehicel

            //DVLA.RegisterVan(van);

            Console.WriteLine(van.Registration);

        }
        private static void Step2()
        {
            var van = new Van() { Make = "Ford", Model = "Transit" };
            // 1. Uncomment line below it should compile and so Run it
            //Accelerator.Accelerate(van);

            // 2. Override MaxSpeed in Van class make it return 70 run. Build and run
            //    What happens?

            // 3. Override IncreasFuelFlow
            //    Replace base.IncreaseFlow(amount) with
            //    System.Threading.Thread.Sleep(amount * 70);
            // 4. Build and Run. What happens?

            // You are varying the behaviour of a derived class
            // When you pass the derived class to a method expecting its base class
            // we get slightly different behaviour.
            // AccelerateToMaxSpeed stays the same, its the form of object we pass it that changes
            // that's Polymorphism
        }



    }
}
