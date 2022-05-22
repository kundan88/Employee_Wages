using System;
using System.Collections;
using System.Collections.Generic;

namespace CalculateEmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee Wage Computation!");
            Console.WriteLine();
            EmployeeWageComputaion wage = new EmployeeWageComputaion();
            wage.AddCompany("TATA", 20, 8, 4, 100, 20);
            wage.AddCompany("Mahindra", 30, 8, 4, 100, 40);
            wage.AddCompany("Microsoft", 100, 8, 4, 100, 30);

            
            int[] wages = new int[3];
            wages[0] = wage.CalculateWage("Microsoft");
            wages[1] = wage.CalculateWage("Tata");
            wages[2] = wage.CalculateWage("Mahindra");

            foreach (var item in wages)
            {
                Console.WriteLine(item);
            }

        }
    }
}

