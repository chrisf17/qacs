using System;
namespace Exercise9.Inheritance.Solution
{
    public static class DVLA
    {
        static int nextRegNum = 100;
        const string BaseRegPlate = "ABC";

        public static void RegisterVehicle(Vehicle v)
        {
            v.Registration = $"{BaseRegPlate}{nextRegNum++}";
        }


        //public static void RegisterVan(Van v)
        //{
        //    v.Registration = $"{BaseRegPlate}{nextRegNum++}";
        //}
        //public static void RegisterCar(Car v)
        //{
        //    v.Registration = $"{BaseRegPlate}{nextRegNum++}";
        //}
        //public static void RegisterTruck(Truck v)
        //{
        //    v.Registration = $"{BaseRegPlate}{nextRegNum++}";
        //}

    }
}
