using System;


public abstract class Transport
{
	double fuel;
	double consume;
	double distance = 0;
	double volume;
	public virtual double Fuel
	{



		get {  return fuel; }
		set { fuel = value; }
	}
	public virtual double Consume
	{ get;set;}
	public double Distance
	{ get; set;}
	public double Volume
	{  get; set;}

	public Transport(double fuel, double consume, double volume = 0)
	{
		Refuel(fuel);
		Consume = consume;
		Volume = volume;
	}
	public virtual void Drive(double distance)
	{
		double fullConsume = Consume * distance;
		if (Fuel >= fullConsume)
		{
			Fuel -= fullConsume;
			Console.WriteLine($"{this.GetType().Name} travelled {0} km", distance);
			Distance += distance;
		}
		else
			Console.WriteLine($"{this.GetType().Name}");

	}
	public virtual void Refuel(double fuel)
	{
		if (fuel < 0)
			Console.WriteLine("Fuel must be positive!");
		else if (fuel > Volume)
			Console.WriteLine("Cannot fit {0} in the tank", fuel);
		else
			this.Fuel = fuel;
	}
    public override string ToString()
    {
        return $"{this.GetType().Name}: {fuel:2F}";
    }
}
