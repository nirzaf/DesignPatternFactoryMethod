namespace DesignPatternFactoryMethod
{
    public class BusCreator : VehicleCreator
    {
        protected override Vehicle MakeVehicle()
        {
            Vehicle vehicle = new Bus();
            vehicle.capacity = 50;
            return vehicle;
        }
    }
}
