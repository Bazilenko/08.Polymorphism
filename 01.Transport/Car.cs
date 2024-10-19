using System;

public class Car : Transport
{
	double fuel;
	double consume;
	public Car(double fuel, double consume, double volume) : base(fuel, consume, volume) {}
    public override void Drive(double distance)
    {
		double fullConsume = distance * (Consume + 0.9);
		if (fullConsume <= Fuel)
		{
			Fuel -= fullConsume;
			Console.WriteLine("Car travelled {0} km", distance);
			Distance += distance;
		}
		else
			Console.WriteLine("Car needs refueling!");
    }
}
