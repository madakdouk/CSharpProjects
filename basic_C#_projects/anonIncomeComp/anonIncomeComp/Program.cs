using System;

namespace anonIncomeComp
{
    internal class Program
    {
        static void Main()
        {
            //printing intro message
            Console.WriteLine("Anonymous Income Comparison Program\n");

            //ask person 1 about their hourly pay
            Console.WriteLine("Person 1\nHourly Rate?");
            //take input and store variable
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            //ask person 1 how many hours worked per week
            Console.WriteLine("Hours worked per week?");
            byte hours1 = Convert.ToByte(Console.ReadLine());

            //person 2 hourly rate
            Console.WriteLine("\nPerson 2\nHourly Rate?");
            //take input and store variable
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            //ask person 2 how many hours worked per week
            Console.WriteLine("Hours worked per week?");
            byte hours2 = Convert.ToByte(Console.ReadLine());

            //calculate annual salary of person 1
            decimal annualSalary1 = hourlyRate1 * hours1 * 52;
            //print annual salary of person 1
            Console.WriteLine("\nAnnual Salary of Person 1:\n" + annualSalary1);

            //calculate annual salary of person 2
            decimal annualSalary2 = hourlyRate2 * hours2 * 52;
            //print annual salary of person 2
            Console.WriteLine("Annual Salary of Person 2:\n" + annualSalary2);

            //check if person 1 salary is greater than person 2 salary
            bool compare = annualSalary1 > annualSalary2;
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?\n" + compare);
            Console.ReadLine();
        }
    }
}
