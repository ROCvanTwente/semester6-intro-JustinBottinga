using S6_CSHARP_02.Interfaces;

namespace S6_CSHARP_02
{
    public class Car : IVehicle
    {
        public int Speed { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }

        public Car(int speed, int wheels, string color)
        {
            Speed = speed;
            Wheels = wheels;
            Color = color;
        }

        public string SpeedUp()
        {
            Speed += 10;

            return "The car is speeding up!";
        }

        public string SlowDown()
        {
            Speed -= 10;

            return "The car is slowing down!";
        }

        public string Print()
        {
            return "The car is going at " + Speed + " mph. It has " + Wheels + " wheels and is " + Color + " in color.";
        }
    }
}
