//UC5
using System;

namespace CalculateEmployeeWage
{
    internal class Program
    {
        public const int empRatePrHr = 20;
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int numOfDays = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            int workHr;
            int empWage;
            int totalWage = 0;
            for (int days = 0; days < numOfDays; days++)
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
                empWage = empRatePrHr * workHr;
                totalWage += empWage;
            }
            Console.WriteLine("Employee total wage is " + totalWage);
        }
    }
}
