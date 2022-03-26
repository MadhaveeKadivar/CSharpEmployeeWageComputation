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

            const int isFullTime = 1; 
            const int isPartTime = 2;
            const int wagePerHour = 20;
            int empWorkHour = 0;
            int empDailyWage = 0;
            Random random = new Random(); // Creating object of Random class
            int check = random.Next(0, 3); // Generating random number 0 or 1
            if(check == isFullTime) // Checking that employee is present for full time
            {
                Console.WriteLine("Employee is Present for Full Time");
                empWorkHour = 8;
            }
            else if (check == isPartTime) //Checking that employee is present for part time
            {
                Console.WriteLine("Employee is Present for Part Time");
                empWorkHour = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empWorkHour = 0;
            }
            empDailyWage = empWorkHour*wagePerHour; // Calculating Daily Wage of Employee
            Console.WriteLine($"\nEmployee Daily Wage : {empDailyWage}\n");
            Console.ReadLine();
        }
    }
}
