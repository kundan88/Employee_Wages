//UC2

using System;

namespace CalculateEmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            int empRatePrHr = 20; 
            int empHr;
            int empWage;
            int isPresent = 1;  
                                
            int employeeStatus = new Random().Next(0, 2);

            if (employeeStatus == isPresent)
            {
                Console.WriteLine("Employee is Present");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHr = 0;
            }

            empWage = empRatePrHr * empHr;
            Console.WriteLine("Employees daily wage is " + empWage);
        }
    }
}
