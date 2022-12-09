using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWage
{
    public class Wages : IEmployeeWageForCompany
    {
        static int day_hr;
        List<ParticularCompany> companyDetailsList;
        public int ToMonWag = 0;                 
        int Company_number = 0;
        public Wages()
        {
            this.companyDetailsList = new List<ParticularCompany>();      
        }

        public void AddDetails(String company, int WaPhr, int max_workDays, int max_workHrs)
        {
            ParticularCompany NewCompany = new ParticularCompany(company, WaPhr, max_workDays, max_workHrs);
            companyDetailsList.Add(NewCompany);
        }

        public void perCompany()
        {
            foreach (var NewCompany in companyDetailsList)
            {
                Console.WriteLine($"Total wage for the company {NewCompany.company} is ");
                NewCompany.TWage(compute(NewCompany));
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