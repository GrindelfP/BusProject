namespace WorkingWithSasha;

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