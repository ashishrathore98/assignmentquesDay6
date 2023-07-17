using System;

namespace MonthlySalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.Write("Enter your choice (1-3): ");
            int employeeType = int.Parse(Console.ReadLine());

            switch (employeeType)
            {
                case 1:
                    CalculateSalaryForHR();
                    break;
                case 2:
                    CalculateSalaryForAdmin();
                    break;
                case 3:
                    CalculateSalaryForSoftwareDeveloper();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.ReadLine();
        }

        static void CalculateSalaryForHR()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());

            int monthlySalary = CalculateSalary(workingHours, numberOfWorkingDays, 0, 0);
            Console.WriteLine("Monthly Salary: $" + monthlySalary);
        }

        static void CalculateSalaryForAdmin()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());
            Console.Write("Enter project handles: ");
            int projectHandles = int.Parse(Console.ReadLine());

            int monthlySalary = CalculateSalary(workingHours, numberOfWorkingDays, projectHandles, 0);
            Console.WriteLine("Monthly Salary: $" + monthlySalary);
        }

        static void CalculateSalaryForSoftwareDeveloper()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());
            Console.Write("Enter project handles: ");
            int projectHandles = int.Parse(Console.ReadLine());
            Console.Write("Enter extras: ");
            int extras = int.Parse(Console.ReadLine());

            int monthlySalary = CalculateSalary(workingHours, numberOfWorkingDays, projectHandles, extras);
            Console.WriteLine("Monthly Salary: $" + monthlySalary);
        }

        static int CalculateSalary(int workingHours, int numberOfWorkingDays, int projectHandles = 0, int extras = 0)
        {
            int basicSalary = workingHours * numberOfWorkingDays * 100;
            int projectSalary = projectHandles * 3000;
            int extrasSalary = extras * 2000;

            int monthlySalary = basicSalary + projectSalary + extrasSalary;
            return monthlySalary;
        }
    }
}