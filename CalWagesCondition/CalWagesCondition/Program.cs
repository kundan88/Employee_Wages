//UC6

using System;

namespace CalculateEmployeeWage
{
    internal class Program
    {
        public const int empRatePrHr = 20;
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int numOfDays = 20;
        public const int maxHrs = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            int workHr;
            int totalWrkHr = 0;
            int totalWage;
            int totalWrkDays = 0;
            while (totalWrkHr < maxHrs && totalWrkDays < numOfDays)
            {
                int employeeStatus = new Random().Next(0, 2);
                switch (employeeStatus)
                {
                    case isFullTime:
                        workHr = 8;
                        break;
                    case isPartTime:
                        workHr = 4;
                        break;
                    default:
                        workHr = 0;
                        break;
                }
                totalWrkHr += workHr;
                totalWrkDays++;
            }
            totalWage = totalWrkHr * empRatePrHr;
            Console.WriteLine("Employee total wage is " + totalWage
                + " for {0} working Days", totalWrkDays);
        }
    }
}