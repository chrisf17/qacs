using System;
namespace Exercise20.Events.Solution2
{
    public class Car
    {
        public event EventHandler SpeedChanged;

        int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = value;
                SpeedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public int MaxSpeed => 120;
        
        public void Accelerate(int amount)
        {
            System.Threading.Thread.Sleep(amount * 80);
        }

    }
}
