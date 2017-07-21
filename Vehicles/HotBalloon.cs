using System;

namespace vehicles.Vehicles
{
  public class HotBalloon : Vehicle, IAirBased
  {
    public int Wheels { get; set; } = 0;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 4;
    public bool Winged { get; set; } = false;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 3.1;
    public double MaxAirSpeed { get; set; } = 39.0;

    public void Drive()
    {
      throw new NotImplementedException();
    }

    public void Fly()
    {
      Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
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