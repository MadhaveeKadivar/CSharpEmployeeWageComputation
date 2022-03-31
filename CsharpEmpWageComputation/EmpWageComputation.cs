using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEmpWageComputation
{ 
    internal class EmpWageComputation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompany("Bridgelabz", 20, 20, 100);
            empWageBuilder.AddCompany("TCS", 40, 25, 100);
            empWageBuilder.IterateOverListOfCompany();
            Console.WriteLine($"\nTotal Wage for Bridgelabz company is : {empWageBuilder.getTotalWage("Bridgelabz")}");
            Console.WriteLine($"\nTotal Wage for TCS company is : {empWageBuilder.getTotalWage("TCS")}");
            Console.ReadLine();
        }
    }
}
