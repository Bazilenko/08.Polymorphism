using System;

public class Cat : Feline
{
	public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
	{
	}
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
    public override void Eat(Food food)
    {
        if (food is Meat || food is Vegetable)
        {
            Weight += food.Quantity * 0.3;
            FoodEaten += food.Quantity;
        }
        else
            Console.WriteLine($"{this.GetType().Name} doesnt eat {food.GetType().Name}");
    }
}
