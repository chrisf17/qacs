using System;
namespace Exercise20.Events.Solution1
{
    public class SpeedChangedEventArgs:EventArgs
    {
        public int Speed { get; set; }
    }

    public class Car
    {
        public event EventHandler<SpeedChangedEventArgs> SpeedChanged;

        int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                speed = value;
                var args = new SpeedChangedEventArgs { Speed = speed };
                OnSpeedChanged(args);
            }
        }

        protected virtual void OnSpeedChanged(SpeedChangedEventArgs args)
        {
            SpeedChanged?.Invoke(this, args);
        }

        public int MaxSpeed => 120;
        
        public void Accelerate(int amount)
        {
            System.Threading.Thread.Sleep(amount * 80);
        }

    }
}
