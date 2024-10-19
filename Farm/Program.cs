using System;
class Program
{
    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        List<Animal> animals = new List<Animal>();
        Animal animal = null;
        Food food = null;
        string command;
        string[] commands;
        while ((command = Console.ReadLine()) != "End")
        {
            commands = command.Split(" ");

            switch (commands[0])
            {
                case "Owl":
                    animal = new Owl(commands[1], double.Parse(commands[2]), double.Parse(commands[3]));
                    break;
                case "Hen":
                    animal = new Hen(commands[1], double.Parse(commands[2]), double.Parse(commands[3]));
                    break;
                case "Mouse":
                    animal = new Mouse(commands[1], double.Parse(commands[2]), commands[3]);
                    break;
                case "Dog":
                    animal = new Dog(commands[1], double.Parse(commands[2]), commands[3]);
                    break;
                case "Cat":
                    animal = new Cat(commands[1], double.Parse(commands[2]), commands[3], commands[4]);
                    break;
                case "Tiger":
                    animal = new Tiger(commands[1], double.Parse(commands[2]), commands[3], commands[4]);
                    break;
                default:
                    Console.WriteLine("Unknown animal type.");
                    continue;
            }

            animal.MakeSound();
            string foodCommand = Console.ReadLine();
            string[] foodInfo = foodCommand.Split(" ");

            switch (foodInfo[0])
            {
                case "Vegetable":
                    food = new Vegetable(int.Parse(foodInfo[1]));
                    break;
                case "Fruit":
                    food = new Fruit(int.Parse(foodInfo[1]));
                    break;
                case "Meat":
                    food = new Meat(int.Parse(foodInfo[1]));
                    break;
                case "Seeds":
                    food = new Seeds(int.Parse(foodInfo[1]));
                    break;
                default:
                    Console.WriteLine("Unknown food type.");
                    continue;
            }
            animal.Eat(food);
            animals.Add(animal); 
            Console.WriteLine(animal.ToString());
            
        }
    }
}

