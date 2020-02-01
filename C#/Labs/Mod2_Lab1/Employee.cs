using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab1
{
    public abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;

        public string Name { get => employeeName; set => employeeName = value; }
        public double BaseSalary { get => employeeBaseSalary; set => employeeBaseSalary = value; }
        public int ID { get => employeeId; set => employeeId = value; }

        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.ID;
        }

        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        public abstract String employeeStatus();
        
    }
}
