using System;

public abstract class Animal
{
	string name;
	double weight;
	int foodEaten;
	public double Weight {  get; set; }
	public int FoodEaten {  get; set; }
	public string Name { get; set; }
	public Animal(string name, double weight)
	{
		Name = name;
		Weight = weight;
		FoodEaten = 0;
	}
	public abstract void MakeSound();
	public abstract void Eat(Food food);
    public override string ToString()
    {
        return $"{GetType().Name} [{Name}, {Weight}, {FoodEaten}]";
    }
}
