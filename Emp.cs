using System;
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
            int fullTime = 1;
            Random rnd = new Random();
            int attendCheck = rnd.Next(0, 2);
            if (attendCheck == fullTime)
            {
                Console.WriteLine("The Employee is present");
            }
            else
            {
                Console.WriteLine("The Employee is absent");
            }
            Console.ReadLine();
        }
        public int fullTime = 1;
        public int partTime = 2;
        public int empHr = 0;
        public int empWage = 0;
        public int totalWage = 0;
        public void Wage(string comp, int wagePerHR, int totalWorkingdays, int totalWorkingHR)
        {
            for (int i = 0; i < totalWorkingdays; i++)
            {

                Random random = new Random();
                int attendCheck = random.Next(0, 3);
                if (attendCheck == fullTime)
                {
                    empHr = 8;
                }
                else if (attendCheck == partTime)
                {
                    empHr = 4;
                }
                else
                {
                    empHr = 0;
                }
                empWage = empHr * wagePerHR;
                totalWage = totalWage + empWage;
            }
                Console.WriteLine($"Employee wage is {empWage}");
                totalDay++;
            } 
            while (totalEmpHr <= totalWorkingHR && totalDay < totalWorkingdays);
            Console.WriteLine($"The total working days per month is {totalWorkingdays} and total working hours is {totalEmpHr}");
            empWage = totalEmpHr * wagePerHR;
            Console.WriteLine($"Employee wage is {empWage}");
        
        }
    }
}
