using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            // Create each person object
            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            Person p1 = new Person();
            Person p2 = new Person();

            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            // Intro message
            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("\n|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");

            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            // Set up person 1
            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("\n~~< Person 1 >~~");
            // Request user for hourly rate
            Console.WriteLine("Hourly Rate?");
            p1._Rate = int.Parse(Console.ReadLine());
            // Request user for hours worked in a week
            Console.WriteLine("Hours worked per week?");
            p1._Wk_Hr = int.Parse(Console.ReadLine());


            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            // Set up person 2
            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("\n~~< Person 2 >~~");
            // Request user for hourly rate
            Console.WriteLine("Hourly Rate?");
            p2._Rate = int.Parse(Console.ReadLine());
            // Request user for hours worked in a week
            Console.WriteLine("Hours worked per week?");
            p2._Wk_Hr = int.Parse(Console.ReadLine());


            Console.WriteLine("\n|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n");
            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            // Calculate annual gross income
            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            // Ease of reading variables
            float p1_A = p1.Annual;
            float p2_A = p2.Annual;
            // Calculate deferance
            float annualDif = (p1_A > p2_A) ? p1_A - p2_A : p2_A - p1_A;


            // ~~~~~~~~~~~~~~~~~~~~~~~~~
            // Outro messages
            // ~~~~~~~~~~~~~~~~~~~~~~~~~

            // Return the results from the calculations
            Console.WriteLine("\n|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n");
            Console.WriteLine($"Annual salary of Person 1:\n >| {p1_A.ToString("C")}");
            Console.WriteLine($"Annual salary of Person 2:\n >| {p2_A.ToString("C")}");
            Console.WriteLine("\n");

            Console.WriteLine($"Does Person 1 make more money than Person 2?");
            // Return result of if Person 1 is greater than Person 2
            Console.WriteLine($" >| {(p1_A > p2_A)}");
            // Print deferance
            Console.WriteLine($" >| The diferance is: {annualDif.ToString("C")}");
            Console.WriteLine("\n|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.ReadLine();
        }
    }

    class Person
    {
        // The rate of pay
        public int _Rate;
        // The weekly hours worked
        public int _Wk_Hr;
        // Used to calculate the number of pay days
        private static bool hasHolidays = true;
        // Number of work days in a year
        private int annualWorkDays = hasHolidays ? 235 : 260;
        // Return the annual salary
        public float Annual => (_Rate * _Wk_Hr) * (annualWorkDays);
        // Constructor with default parameter
        public Person(bool includeHolidays = true)
        {
            hasHolidays = includeHolidays;
        }
    }
}
