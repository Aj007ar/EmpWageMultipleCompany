namespace EmpWageMultipleCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************WELCOME TO EMPLOYEE WAGE FOR MULTIPLE COMPANY****************");
            DailyWage();
        }
        public static void DailyWage()
        {
            int Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 1)
            {
                int empRatePerHr = 20;
                int empHour = 8;
                int salary = (empRatePerHr * empHour);
                Console.WriteLine("Employee present for full day then salary is: " + salary);
            }
            else
            {
                int salary = 0;
                Console.WriteLine("Employee is Absent then salary is:" + salary);
            }
        }
    }
}