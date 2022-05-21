
//UC1
using System;

namespace CalculateEmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            int isPresent = 1;               
            int employeeStatus = new Random().Next(0, 2);

            if (employeeStatus == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
