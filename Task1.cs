using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
    }
    abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Mileage;

        public Vehicle(string color, string brand, double mileage)
        {
            Color = color;
            Brand = brand;
            Mileage = mileage;
        }

        public virtual void ShowInfo()
        {
           Console.WriteLine("Brand: " + Brand); 
           Console.WriteLine("Color: " + Color);
           Console.WriteLine("Mileage: " + Mileage);

        }

        public virtual void Drive(double distance)
        {
           Console.WriteLine("Driving..."); 
        }
    }

    class Car : Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1km;
        public Car(double fuel_capacity, double current_fuel, double fuelfor1km,string color, string brand, double mileage) : base(color, brand, mileage)
        {
            Color = color;
            Brand = brand;
            Mileage = mileage;
            FuelCapacity = fuel_capacity;
            CurrentFuel = current_fuel;
            FuelFor1km = fuelfor1km;
        }

        public override void Drive(double distance)
        {
            if (distance * FuelFor1km < CurrentFuel)
            {
                CurrentFuel -= distance * FuelFor1km;
                Mileage += distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel.");
            }
        }
    }

    class Bicycle : Vehicle
    {
        public Bicycle(string color, string brand, double mileage) : base(color, brand, mileage)
        {
            Color = color;
            Brand = brand;
            Mileage = mileage;
        }

        public override void Drive(double distance)
        {
            Mileage += distance;
        }
    }
}
