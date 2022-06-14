namespace DesignPatternFactoryMethod
{
    public class BoatCreator : VehicleCreator
    {
        protected override Vehicle MakeVehicle()
        {
            Vehicle vehicle = new Boat();
            vehicle.capacity = 150;
            return vehicle;
        }
    }
}
