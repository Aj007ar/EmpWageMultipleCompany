namespace EmpWageMultipleCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************WELCOME TO EMPLOYEE WAGE FOR MULTIPLE COMPANY****************");
            Empwage();
        }
        public static void Empwage()
        {
            const int Full_Time = 1;
            const int Part_Time = 2;
            const int empRatePerHr = 20;
            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            switch (empCheck)
            {
                case Full_Time:
                    empHr = 8;
                    Console.WriteLine("employee is Present");
                    break;
                case Part_Time:
                    empHr = 4;
                    Console.WriteLine("employee is present for Half Day");
                    break;
                default:
                    empHr = 0;
                    Console.WriteLine("Employee is Absent");
                    break;

            }
            empWage = (empRatePerHr * empHr);
            Console.WriteLine("Then Salary for employee is:" + empWage);
        }
    }
}