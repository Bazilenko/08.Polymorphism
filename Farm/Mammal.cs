using System;

public abstract class Mammal : Animal
{
	string livingRegion;
	public string LivingRegion
	{ get; set; }
	public Mammal(string name, double weigth, string livingRegion) : base(name, weigth)
    {
        LivingRegion = livingRegion;
    }
    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
