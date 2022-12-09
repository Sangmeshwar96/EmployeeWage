using EmployeeWage;

namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--Welcome to employee wage computation program--");
            Console.WriteLine(" ");

            IEmployeeWageForCompany comp = new Wages();
            comp.AddDetails("TATA", 200, 20, 8);
            comp.AddDetails("Wipro", 300, 25, 9);
            comp.AddDetails("TCS", 200, 25, 9);
            comp.AddDetails("Infy", 280, 20, 8);
            comp.AddDetails("IBM", 150, 27, 9);
            comp.perCompany();
            comp.QuerrySolved("TATA");
        }
    }
}
