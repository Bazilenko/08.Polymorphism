using System;

public class Bus : Transport
{
	
	public Bus(double fuel, double consume, double volume) : base(fuel, consume, volume){}
	public void DriveWithPeople(double distance)
	{
		double fullConsume = distance * (Consume + 1.4);
		if (Fuel >= fullConsume)
		{
			Console.WriteLine($"Bus travelled {0} km", distance);
			Fuel -= fullConsume;
			Distance += distance;
		}
		else
			Console.WriteLine("Bus needs refueling!");
	}
}
