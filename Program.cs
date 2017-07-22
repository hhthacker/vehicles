using System;
using System.Linq;
using System.Collections.Generic;
using vehicles.Vehicles;

namespace vehicles
{
    public class Program
    {
            List<Vehicle> AirVehicle { get; set; } =  new List<Vehicle>();
            List<Vehicle> WaterVehicle { get; set; } =  new List<Vehicle>();
            List<Vehicle> LandVehicle { get; set; } =  new List<Vehicle>();

        public static void Main(string[] args) 
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            
            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()

        }
    }
}