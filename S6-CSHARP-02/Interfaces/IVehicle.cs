
namespace S6_CSHARP_02.Interfaces
{
    public interface IVehicle
    {
        public int Speed { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }

        public string SpeedUp();

        public string SlowDown();

        public string Print();
    }
}
