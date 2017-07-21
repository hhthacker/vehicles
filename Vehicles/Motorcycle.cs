using System;

namespace vehicles.Vehicles
{
    public class Motorcycle : Vehicle, IGroundBased
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxLandSpeed { get; set; } = 160.4;

        public Motorcycle(string name) 
        {
            Name = name;
        }
        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
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