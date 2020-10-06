namespace InterfaceExercise
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int NumberOfDoors { get; set; }
        int NumberOfWheels { get; set; }
        string Year { get; set; }

        void Drive();
    }
}