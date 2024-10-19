using System;

public class Dog : Mammal
{
	public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
	{
	}
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += food.Quantity * 0.4;
            FoodEaten += food.Quantity;
        }
        else
            Console.WriteLine($"{this.GetType().Name} doesnt eat {food.GetType().Name!}");
    }
}
