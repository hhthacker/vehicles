using System;

namespace vehicles.Vehicles
{
    public class Bicycle : Vehicle, IGroundBased
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 1;
        public string TransmissionType { get; set; } = "Leg Power";
        public double EngineVolume { get; set; } = 0.3;
        public double MaxLandSpeed { get; set; } = 16.2;

        public Bicycle(string name, string terraintype)
        {
            Name = name;
        }
        public void Drive()
        {
            Console.WriteLine("The bicycle rolls around!");
        }
        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}