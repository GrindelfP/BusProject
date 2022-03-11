namespace WorkingWithSasha;

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
