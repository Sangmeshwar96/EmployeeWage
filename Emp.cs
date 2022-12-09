using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Emp
    {
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
        }
    }
}