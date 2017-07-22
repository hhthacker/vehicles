using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var airVehicles = new List<IAirVehicle> {
                new Cessna(), new HotBalloon()
            };
            
            foreach (var vehicle in airVehicles)
            {
                vehicle.Fly();
                vehicle.Land();
                Console.WriteLine();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var groundVehicles = new List<IGroundVehicle> {
                new Motorcycle(), new Bicycle()
            };

            foreach (var vehicle in groundVehicles)
            {
                vehicle.Start();
                vehicle.Stop();
                Console.WriteLine();
                
                var driveableVehicle = vehicle as IDriveableVehicle;
                if (driveableVehicle != null) {
                    driveableVehicle.Drive();
                    driveableVehicle.Stop();
                }
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var waterVehicles = new List<IWaterVehicle> {
                new Canoe(), new JetSki()
            };

            foreach (var vehicle in waterVehicles)
            {
                vehicle.Start();

                var driveableVehicle = vehicle as IDriveableVehicle;
                if (driveableVehicle != null) {
                    driveableVehicle.Drive();
                    driveableVehicle.Stop();
                }
            }
        }
    }
}