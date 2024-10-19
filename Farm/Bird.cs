using System;
using System.Xml.Linq;

public abstract class Bird : Animal
{
	double wingSize;
	double WingSize {  get; set; }
	public Bird(string name, double weight, double wingSize) : base(name, weight)
	{
		WingSize = wingSize;
	}
    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
    }
}
