namespace WorkingWithSasha;

internal static class Program
{
    private static void Main()
    {
        var microBus = new Bus(90, false, 2);
        Console.WriteLine(microBus);
        if (!microBus.IsPublic) microBus.IsPublic = true;
        microBus.Drive(133);
        Console.WriteLine(microBus);
    }
}
internal abstract class Vehicle
{
    protected VehicleType Type { get; }
    protected int MaxSpeed { get; }
    protected internal bool IsPublic { get; set; }
    protected int Kilometerage { get; set; }
    protected Vehicle(VehicleType vehicleType, int maxSpeed, bool isPublic)
    {
        Type = vehicleType;
        MaxSpeed = maxSpeed;
        IsPublic = isPublic;
        Kilometerage = 0;
    }
    public override string ToString()
    {
        return "Vehicle type: " + Type + ". Max speed: " + MaxSpeed + ", belongs to public transport: " + IsPublic + 
            ", and it passed " + Kilometerage + ".";
    }

}

internal class Bus: Vehicle
{
    private int NumOfDoors { get; }
    public Bus(int maxSpeed, bool isPublic, int numberOfDoors) : base(VehicleType.Bus, maxSpeed, isPublic)
    {
        NumOfDoors = numberOfDoors;
    }

    public void Drive(int numOfKilometres)
    {
        Kilometerage += numOfKilometres;
    }
    
    public override string ToString()
    {
        return "Vehicle type: " + Type + ". Max speed: " + MaxSpeed + ", belongs to public transport: " + IsPublic + 
               ", and it passed " + Kilometerage + ". It has " + NumOfDoors + " brilliant doors.";
    }
}
internal enum VehicleType
{
    Bus, 
    Trolleybus,
    Tram,
    Coach,
    Car,
    Train,
    Plane,
    Spaceship
}