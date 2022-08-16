namespace EmpWageMultipleCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************WELCOME TO EMPLOYEE WAGE FOR MULTIPLE COMPANY****************");
            CheckAttendance();
        }
        public static void CheckAttendance()
        {
            int Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}