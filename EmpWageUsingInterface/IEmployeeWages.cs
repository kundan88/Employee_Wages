using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateEmployeeWage
{
    internal interface IEmployeeWage
    {
        void AddCompany(string CompanyName, int EmpWagePrHr, int FullTimeWrkHr, int PartTimeWrkHr,
            int MaxWrkHrs, int MaxWrkDays);
        int CalculateWage(string CompanyName);
    }
}