using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new TechnicalEmployee("Lily");
            var employee2 = new TechnicalEmployee("Zhan Yang");
            var employee3 = new BusinessEmployee("Wany");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
