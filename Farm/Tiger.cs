using System;

public class Tiger : Feline
{
	public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
	{
	}
    public override void MakeSound()
    {
        Console.WriteLine("Roar!");
    }
    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += food.Quantity * 1;
            FoodEaten += food.Quantity;
        }
        Console.WriteLine($"{this.GetType().Name} doesnt eat {food.GetType().Name}");
    }
}
