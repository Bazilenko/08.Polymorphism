using System;

public class Truck : Transport
{

    public Truck(double fuel, double consume, double volume) : base(fuel, consume, volume) { }
    
    public override void Drive(double distance)
    {
       double fullConsume = (Consume + 1.6) * distance;
		if (fullConsume <= Fuel)
		{
			Fuel -= fullConsume;
			Console.WriteLine("Truck travelled {0} km", distance);
			Distance += distance;
		}
		else
			Console.WriteLine("Truck needs refueling!");
    }
    public override void Refuel(double fuel)
    {
        base.Refuel(fuel * 0.95);
    }
    
}
