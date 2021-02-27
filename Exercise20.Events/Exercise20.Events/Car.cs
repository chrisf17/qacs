using System;
namespace Exercise20.Events
{
    public class Car
    {
        // 3. Add an event called SpeedChanged
        int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = value;
                //4. Invoke SpeedChanged
                // SpeedChanged?.Invoke(this, EventArgs.Empty);

                //5. Go back to Program class
            }
        }

        public int MaxSpeed => 120;
        
        public void Accelerate(int amount)
        {
            System.Threading.Thread.Sleep(amount * 80);
        }

    }
}
