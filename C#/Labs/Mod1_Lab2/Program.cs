using System;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            var Car2 = new Car("Red", 2008);

            int carCount = Car.CountCars();
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
    }
    
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        private static int instances = 0;

        public Car()
        {
            instances++;
        }
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }
        public Car(int year, int mileage)
        {
            this.Year = Year;
            this.Mileage = mileage;
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }
    }
}
