using System;
using System.Collections.Generic;

namespace CalculateEmployeeWage
{
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
        public int CalculateWage(string CompanyName)
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
            return totalWage;
        }

    }
}

