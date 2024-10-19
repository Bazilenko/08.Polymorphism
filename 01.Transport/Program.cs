using System;
class Program
{
    static void Main()
    {
        Menu();
    }
    static void Menu() {
        string command;
        string[] commands;
        string[] Info1 = Console.ReadLine().Split(" ");
        Car car = new Car(double.Parse(Info1[0]), double.Parse(Info1[1]), double.Parse(Info1[2]));
        string[] Info2 = Console.ReadLine().Split(" ");
        Truck truck = new Truck (double.Parse(Info2[0]), double.Parse(Info2[1]), double.Parse(Info2[2]));
        string[] Info3 = Console.ReadLine().Split("");
        Bus bus = new Bus(double.Parse(Info3[0]), double.Parse(Info3[1]), double.Parse(Info3[2]));
        while ((command = Console.ReadLine()) != "End")
        {
            commands = command.Split(" ");
            string vehicle = commands[0];
            double distanc = double.Parse(commands[2]);
            if (commands[1] == "Drive")
            {
                if (vehicle == "Car")
                    car.Drive(distanc);
                else if (vehicle == "Truck")
                    truck.Drive(distanc);
                else if (vehicle == "Bus")
                    bus.DriveWithPeople(distanc);
            }
            else if (commands[1] == "EmptyDrive")
                bus.Drive(distanc);
            else if (commands[1] == "Refuel")
            {
                double fuelAmount = double.Parse(commands[2]);
                if (vehicle == "Car")
                {
                    car.Refuel(fuelAmount);
                }
                else if (vehicle == "Truck")
                {
                    truck.Refuel(fuelAmount);
                }
                else if (vehicle == "Bus")
                {
                    bus.Refuel(fuelAmount);
                }
            }

        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}