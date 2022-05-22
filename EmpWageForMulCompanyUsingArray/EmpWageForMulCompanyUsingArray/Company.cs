using System;

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
}