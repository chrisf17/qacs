using System;
namespace Exercise20.Events
{
    public class Accelerator
    {
        public static void AccelerateToMaxSpeed(Car item)
        {
            while (item.Speed < item.MaxSpeed)
            {
                item.Accelerate(5);

            }

        }
    }
}
