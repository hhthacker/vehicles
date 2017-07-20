namespace vehicles
{
    public interface IWaterBased
    {
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    double MaxWaterSpeed { get; set; }
    void Start();
    void Stop();
    }
}