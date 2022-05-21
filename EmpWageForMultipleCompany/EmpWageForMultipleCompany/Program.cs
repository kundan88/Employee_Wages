// UC8

using System;
using System.Collections.Generic;

namespace CalculateEmployeeWage
{
    class Company
    {
        public int EmpWagePrHr;
        public int FullTimeWrkHr;
        public int PartTimeWrkHr;
        public int MaxWrkHrs;
        public int MaxWrkDays;
        public String CompanyName;

        public Company(string companyName, int empWagePrHr, int fullTimeWrkHr, int partTimeWrkHr, int maxWrkHrs, int maxWrkDays)
        {
            CompanyName = companyName;
            EmpWagePrHr = empWagePrHr;
            FullTimeWrkHr = fullTimeWrkHr;
            PartTimeWrkHr = partTimeWrkHr;
            MaxWrkHrs = maxWrkHrs;
            MaxWrkDays = maxWrkDays;
        }
    }
    class EmployeeWageComputaion
    {

        private const int _isFullTime = 1;
        private const int _isPartTime = 2;
        private int totalWage;
        private Dictionary<string, Company> companies = new Dictionary<string, Company>();

        public void AddCompany(string CompanyName, int EmpWagePrHr, int FullTimeWrkHr, int PartTimeWrkHr, int MaxWrkHrs, int MaxWrkDays)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePrHr, FullTimeWrkHr, PartTimeWrkHr, MaxWrkHrs, MaxWrkDays);
            companies.Add(CompanyName.ToLower(), company);
        }

        private int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateWage(string CompanyName)
        {
            int workHr;
            int totalWrkHr = 0;
            int totalWrkDays = 0;

            if (!companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company don't exist");
            companies.TryGetValue(CompanyName.ToLower(), out Company company);

            while (totalWrkHr <= company.MaxWrkHrs && totalWrkDays < company.MaxWrkDays)
            {
                switch (IsEmployeePresent())
                {
                    case _isFullTime:
                        workHr = company.FullTimeWrkHr;
                        break;
                    case _isPartTime:
                        workHr = company.PartTimeWrkHr;
                        break;
                    default:
                        workHr = 0;
                        break;
                }
                totalWrkHr += workHr;
                totalWrkDays++;
            }
            totalWage = totalWrkHr * company.EmpWagePrHr;
            Console.WriteLine("Company name: " + CompanyName);
            Console.WriteLine("Employee total wage is {0} for {1} working days", totalWage, totalWrkDays);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Employee Wage Computation!");
            Console.WriteLine();
            EmployeeWageComputaion wage = new EmployeeWageComputaion();
            wage.AddCompany("TATA", 20, 8, 4, 100, 20);
            wage.AddCompany("Mahindra", 30, 8, 4, 100, 20);
            wage.CalculateWage("Tata");
            wage.CalculateWage("Mahindra");
        }
    }
}
