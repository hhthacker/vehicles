using System;

namespace vehicles
{
    public class JetSki : IWaterVehicle, IDriveableVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 1;
        public string TransmissionType { get; set; } = "Variable";
        public double EngineVolume { get; set; } = 1.1;
        public double MaxSpeed { get; set; } = 42;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }
        public void Start()
        {
            Console.WriteLine("Hey watch this");
        }
        public void Stop()
        {
            Console.WriteLine("Call an ambulance");
        }
    }
}
