namespace vehicles
{
    public interface IAirVehicle : IVehicle
    {
        bool Winged { get; set; }
        double MaxSpeed { get; set; }
        void Fly();
        void Land();
    }
}