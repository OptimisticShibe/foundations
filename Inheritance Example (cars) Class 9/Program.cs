// File: Inheritance.cs
using System;

class Vehicle
{
    public string Name;
    public int Passengers;
    public int Speed;

    public Vehicle(string name, int passengers, int speed)
    {
        Name = name;
        Passengers = passengers;
        Speed = speed;
    }
}

class Automobile : Vehicle //Inherits Vehicle class
{
    public int Windows;

    public Automobile(string name, int passengers, int speed, int windows)
        : base(name, passengers, speed) //have to connect to base to specify inheritance
    {
        Windows = windows;
    }
}

class Motorcycle : Vehicle
{
    public int Seats;

    public Motorcycle(string name, int passengers, int speed, int seats)
        : base(name, passengers, speed)
    {
        Seats = seats;
    }
}


class TestClass
{
    public static void PrintInfo(Vehicle v)
    {
        Console.WriteLine("Name is {0}", v.Name);
        Console.WriteLine("Passengers is {0}", v.Passengers);
    }

    static void Main()
    {
        Vehicle MyVehicle = new Vehicle("My Vehicle", 0, 100);
        Automobile HondaCivic = new Automobile("Honda Civic", 2, 120, 2);
        Motorcycle Harley = new Motorcycle("Harley Low Rider", 1, 100, 1);

        PrintInfo(MyVehicle);
        PrintInfo(HondaCivic);
        PrintInfo(Harley);
    }
}