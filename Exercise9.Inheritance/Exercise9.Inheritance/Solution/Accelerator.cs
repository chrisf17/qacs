using System;
namespace Exercise9.Inheritance.Solution
{
    public static class Accelerator
    {
        public static void Accelerate(Vehicle v)
        {
            while (v.Speed < v.MaxSpeed)
            {
                v.Accelerate();
                Console.WriteLine(v);
            }
        }
    }
}
