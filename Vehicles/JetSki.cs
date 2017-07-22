using System;

namespace vehicles.Vehicles
{
    public class JetSki : Vehicle, IWaterBased
    {
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public JetSki()
        {
            
        }
        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
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
