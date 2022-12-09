using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWage
{
    public class Wages 
    {
        static int day_hr;
        ParticularCompany[] companyDetails;      
        public int ToMonWag = 0;              
        int Company_number = 0;
        public Wages()
        {
            this.companyDetails = new ParticularCompany[5];       
        }

        public void AddDetails(String company, int WaPhr, int max_workDays, int max_workHrs)
        {
            companyDetails[Company_number] = new ParticularCompany(company, WaPhr, max_workDays, max_workHrs);
            Company_number++;
        }

        public void perCompany()               
        {
            for (int x = 0; x < 5; x++)
            {
                Console.Write("Total Wage for the company " + companyDetails[x].company + " is = ");
                companyDetails[x].TWage(compute(this.companyDetails[x]));
            }
        }
        public int wage(int WaPhr)               
        {
            int ch = new Random().Next(0, 3);
            day_hr = 0;
            switch (ch)
            {
                case 1:
                    day_hr = 4;
                    break;
                case 2:
                    day_hr = 8;
                    break;
                default:
                    day_hr = 0;
                    break;
            }
            return (WaPhr * day_hr);
        }
        public int compute(ParticularCompany Company)       
        {
            int days = 0;
            int totHrs = 0;                  

            while (days < Company.max_workDays && totHrs < Company.max_workHrs)
            {
                ToMonWag = ToMonWag + (wage(Company.WaPhr));
                days++;
                totHrs = totHrs + day_hr;
                if (totHrs > Company.max_workHrs)                           
                {
                    ToMonWag = ToMonWag - ((totHrs - Company.max_workHrs) * Company.WaPhr);
                }
            }
            return ToMonWag;
        }

    }
}