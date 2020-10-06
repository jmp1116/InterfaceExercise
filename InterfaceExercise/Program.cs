using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myFirstCar = new Car { Year = "2005", Make = "Mazda", Model = "Protege5", NumberOfDoors = 4, NumberOfWheels = 4 };
            Truck myFirstTruck = new Truck { Year = "2012", Make = "Chevy", Model = "Z71", NumberOfWheels = 4, NumberOfDoors = 4, BedSize = 6, HasToolBox = true };
            SUV myFirstSUV = new SUV { Year = "2010", Make = "Toyota", Model = "4Runner", NumberOfWheels = 4, NumberOfDoors = 4, CargoSize = 4, HasThirdRowSeating = false };
           


            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(myFirstCar);
            vehicles.Add(myFirstTruck);
            vehicles.Add(myFirstSUV);

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model} Number of Wheels: {vehicle.NumberOfWheels} Number of Doors: {vehicle.NumberOfDoors}");
                Console.WriteLine();
                vehicle.Drive();
                Console.WriteLine();
            }

        }
    }
}
