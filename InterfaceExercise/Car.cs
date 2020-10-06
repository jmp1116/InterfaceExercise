using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfDoors { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Car is in drive. This is a {GetType().Name}");
        }
    }

}
