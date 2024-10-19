using System;

public abstract class Food
{
	int quantity;
	public int Quantity {  get; set; }
	public Food(int quantity)
	{
		Quantity = quantity;
	}
}
