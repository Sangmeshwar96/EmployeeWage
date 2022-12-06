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
            Emp emp = new Emp();
            emp.Wage("TCS", 20);
            emp.Wage("Infy", 30);
        }
    }
}
