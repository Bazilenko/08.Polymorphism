﻿using System;

public class Owl : Bird
{
	public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
	{
	}
	public override void MakeSound()
	{
		Console.WriteLine("Hoot Hoot");
	}
    public override void Eat(Food food)
    {
        if (food is Meat)
        {
            Weight += food.Quantity * 0.25;
            FoodEaten += food.Quantity;
        }
        else
        {
            Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}
