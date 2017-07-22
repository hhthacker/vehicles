using System;
using System.Collections.Generic;

namespace vehicles
{
    public class Motorcycle : IGroundVehicle, IDriveableVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxSpeed { get; set; } = 160.4;

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }
        public void Start()
        {
            Console.WriteLine("Vroom Vroom");
        }
        public void Stop()
        {
            Console.WriteLine("Skeeeeee Woooop");
        }
    }
}
