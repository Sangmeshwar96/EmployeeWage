using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Emp
    {
        public void Wage()
        {
            const int fullTime = 1;
            const int partTime = 2;
            int empHr = 0;
            int empWage = 0;
            int wagePerHr = 20;

            Random random = new Random();
            int attendCheck = random.Next(0, 3);
            switch (attendCheck)
            {
                case fullTime:
                    empHr = 8;
                    Console.WriteLine("Full time employee");
                    break;
                case partTime:
                    empHr = 4;
                    Console.WriteLine("Part time employee");
                    break;
                default:
                    empHr = 0;
                    Console.WriteLine("The Employee is absent");
                    break;
            }
            empWage = empHr * wagePerHr;
            Console.WriteLine($"The Employee wage is {empWage}");
        }
    }
}