using System;
namespace Exercise9.Inheritance.Starter
{
    public class Vehicle
    {


        public int Speed { get; protected set; }

        public virtual int MaxSpeed => 120;

        public void Accelerate()
        {
            IncreaseFuelFlow(5);
            Speed += 5;
        }
        protected virtual void IncreaseFuelFlow(int amount)
        {
            System.Threading.Thread.Sleep(amount * 120);
        }

        public override string ToString()
        {
            return $"Speed:{Speed}";
        }


    }
}
