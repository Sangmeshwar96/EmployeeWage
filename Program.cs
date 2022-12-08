using System;
using EmployeeWage;
namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome To Employee Wage program---");
            Console.WriteLine("");
            Emp emp1 = new Emp();
            emp1.Wage("TCS", 20, 20, 100);
            Emp emp2 = new Emp();
            emp2.Wage("Infy", 30, 20, 100);
            Console.WriteLine("Total wage for an employee of TCS is : " + emp1.totalWage);
            Console.WriteLine("Total wage for an employee of Infy is : " + emp2.totalWage);
        }
    }
}

