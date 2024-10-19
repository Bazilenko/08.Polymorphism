using System;

public class Mouse : Mammal
{
	public Mouse(string name, double weight,string livingRegion) : base(name, weight,livingRegion)
	{
	}
    public override void MakeSound()
    {
        Console.WriteLine("Squeak");
    }
    public override void Eat(Food food)
    {
        if (food is Vegetable || food is Fruit)
        {
            Weight += food.Quantity * 0.1;
            FoodEaten += food.Quantity;
        }
        else
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
    }
}
