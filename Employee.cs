using System;
using System.Collections.Generic;
using System.Text;

namespace employee_commission_class
{
    class Employee
    {
        // constants
        const double COMMISSION_RATE = .07,
                     FEDERAL_TAX_RATE = .18,
                     RETIREMENT_RATE = .1,
                     SOCIAL_SECURITY_RATE = .06;
        // data members
        private string name;
        private double weeklyTotalSales,
                       commissionIncome,
                       federalTaxes,
                       retirementContrib,
                       socialSecurity,
                       totalDeductions,
                       takeHomePay;
        // properties
        public string Name { set; get; }
        public double WeeklyTotalSales { set; get; }
        // methods
        public double CalculateCommission()
        {
            return weeklyTotalSales * COMMISSION_RATE;
        }
    }
}
