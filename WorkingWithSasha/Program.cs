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