namespace Garage;

public class Zero : Vehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero drives quietly. Vrooom!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Zero leans into the {direction} turn.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero comes to a stop with a soft hum.");
    }
}