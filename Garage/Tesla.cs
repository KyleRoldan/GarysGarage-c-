namespace Garage;


public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla drives silently. Zoom!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {MainColor} Tesla smoothly turns to the {direction}.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla stops with a gentle glide.");
    }
}
