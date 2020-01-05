﻿using System;
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
        // constructor
        public Employee()
        {
            name = "Willy Loman";
            weeklyTotalSales = 10000;
            CalculateTakeHomePay();
        }
        // methods
        public double CalculateCommission()
        {
            return weeklyTotalSales * COMMISSION_RATE;
        }
        public double CalculateTax()
        {
            return commissionIncome * FEDERAL_TAX_RATE;
        }
        public double CalculateRetirement()
        {
            return commissionIncome * RETIREMENT_RATE;
        }
        public double CalculateSocialSecurity()
        {
            return commissionIncome * SOCIAL_SECURITY_RATE;
        }
        public void CalculateTakeHomePay()
        {
            commissionIncome = CalculateCommission();
            federalTaxes = CalculateTax();
            retirementContrib = CalculateRetirement();
            socialSecurity = CalculateSocialSecurity();
            totalDeductions = federalTaxes + retirementContrib + socialSecurity;
            takeHomePay = commissionIncome - totalDeductions;
        }
        public override string ToString()
        {
            string result = String.Format("******* Employee Data Table *******\n");
            result += String.Format("* {0, 12} {0, 18} *\n", "Name:", name);
            return result;
        }
    }
}
