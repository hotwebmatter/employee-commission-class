using System;
using static System.Console;

namespace employee_commission_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables needed to accept user input
            string employeeName;
            double weeklySales;
            Write("Enter employee name: ");
            employeeName = ReadLine();
            weeklySales = ReadDouble("Enter weekly sales: ");
            Employee salesman = new Employee(employeeName, weeklySales);
            WriteLine(salesman.ToString());
        }
        static double ReadDouble(string label)
        {
            double number;
            Write("{0} ", label);
            string userInput = ReadLine();
            while (Double.TryParse(userInput, out number) == false)
            {
                Write("Invalid input!\n{0} ", label);
                userInput = ReadLine();
            }
            return number;
        }
    }
}
