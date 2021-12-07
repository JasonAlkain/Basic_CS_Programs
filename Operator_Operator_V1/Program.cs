using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Operator_V1
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Simplifiers for Console 'I/O'
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(string s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Methods
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {
            // Employee objects to compare
            Employee emp_A = new Employee() { Id = 1 };
            Employee emp_B = new Employee() { Id = 2 };
            Employee emp_C = new Employee() { Id = 2 };
            
            // Temp string variable
            string _ = string.Empty;

            
            
            // compare Employee A to B
            _ = emp_A == emp_B ? "yes" : "No";

            // Print question and result
            WriteLine($"Does the Id of employee A equal employee B?");
            WriteLine($"{_}");

            // compare Employee A to C
            _ = emp_A == emp_C ? "yes" : "No";

            // Print question and result
            WriteLine($"Does the Id of employee A equal employee C?");
            WriteLine($"{_}");

            // compare Employee C to B
            _ = emp_C == emp_B ? "yes" : "No";

            // Print question and result
            WriteLine($"Does the Id of employee C equal employee B?");
            WriteLine($"{_}");

            ReadKey();
        }
    }
}
