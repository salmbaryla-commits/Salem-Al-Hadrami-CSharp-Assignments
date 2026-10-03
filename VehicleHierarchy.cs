using System;

class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;

        Console.WriteLine("Vehicle constructor");
    }

    public void Start()
    {
        Console.WriteLine(Brand + " is starting.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;

        Console.WriteLine("Car constructor");
    }
}

class Bus : Vehicle
{
    public int Capacity;

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Capacity = capacity;

        Console.WriteLine("Bus constructor");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        HasSidecar = hasSidecar;

        Console.WriteLine("Motorcycle constructor");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", 2022, 4);

        Console.WriteLine();

        Bus bus1 = new Bus("Mercedes", 2020, 50);

        Console.WriteLine();

        Motorcycle motorcycle1 = new Motorcycle("Honda", 2023, false);

        Console.WriteLine();

        Console.WriteLine("Starting vehicles:");

        car1.Start();
        bus1.Start();
        motorcycle1.Start();
    }
}
