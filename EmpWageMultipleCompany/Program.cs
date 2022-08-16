namespace EmpWageMultipleCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************WELCOME TO EMPLOYEE WAGE FOR MULTIPLE COMPANY****************");

            CompanyWage("Bridgelabz", 20, 20, 100);
            CompanyWage("Infosys", 40, 20, 100);
          
        }
        public const int Part_Time = 1;
        public const int Full_Time= 2;
        
        public static int CompanyWage(string company, int empRatePrHr, int numOfWorkDays, int maxHrPrMonth)
        {
            int empHr = 0;
            int totalEmpHr = 0;
            int totalWorkDays = 0;

            while (totalEmpHr <= maxHrPrMonth && totalWorkDays < numOfWorkDays)
            {
                totalWorkDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Part_Time:
                        empHr = 4;
                        break;
                    case Full_Time:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;

                }
                totalEmpHr += empHr;               
            }
            int totalempWage = totalEmpHr * empRatePrHr;
            Console.WriteLine("\nTotal Working Day: " +totalWorkDays);
            Console.WriteLine("Total Working hours " +totalEmpHr);
            Console.WriteLine("Total Employee Wage for " + company + " is " + totalempWage);
            return totalempWage;
        }
    }
}