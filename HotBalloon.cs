using System;

namespace vehicles
{
  public class HotBalloon : IAirVehicle
  {
    public int Wheels { get; set; } = 0;
    public int Doors { get; set; } = 1;
    public int PassengerCapacity { get; set; } = 4;
    public bool Winged { get; set; } = false;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 3.1;
    public double MaxSpeed {get; set; } = 39.0;

    public void Fly()
    {
      Console.WriteLine("Floating along woo wee");
    }

    public void Land()
    {
      Console.WriteLine("Softly for the delicate shoes!");
    }
    public void Start()
    {
      Console.WriteLine("Fire up the hot air");
    }

    public void Stop()
    {
      Console.WriteLine("Pop pop");
    }
  }
}