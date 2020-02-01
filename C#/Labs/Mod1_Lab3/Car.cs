using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Lab3
{
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        private static int instances = 0;

        //
        public Car()
        {
            instances++;
        }

        //
        public static int CountCars()
        {
            return instances;
        }
    }
}
