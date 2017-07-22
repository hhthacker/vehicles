using System;

namespace vehicles
{
    public class Bicycle : IGroundVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 1;
        public string TransmissionType { get; set; } = "Leg Power";
        public double EngineVolume { get; set; } = 0.3;
        public double MaxSpeed { get; set; } = 20;

        public void Start()
        {
            Console.WriteLine("Peddle peddle peddle");
        }
        public void Stop()
        {
            Console.WriteLine("Squeeze them brakes!");
        }
    }
}