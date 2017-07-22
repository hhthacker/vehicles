namespace vehicles
{
    public interface IGroundVehicle : IVehicle
    {
        double MaxSpeed { get; set; }
        void Stop();
    }
}