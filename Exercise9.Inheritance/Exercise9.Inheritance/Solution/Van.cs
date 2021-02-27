using System;
namespace Exercise9.Inheritance.Solution
{
    public class Van : Vehicle
    {

        public int Capacity { get; set; }

        public override int MaxSpeed => base.MaxSpeed;
    }
}
