using System;

namespace vehicles
{
    public class Canoe : IWaterVehicle
    {
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Arms";
        public double EngineVolume { get; set; } = 2;
        public double MaxSpeed { get; set; } = 1;
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;

        public void Start()
        {
            Console.WriteLine("Paddle paddle paddle");
        }
    }
}