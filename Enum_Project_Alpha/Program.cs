using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Project_Alpha
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Simplifiers for Console 'I/O'
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(String s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Methods
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {

            WriteLine("What is the current day of the week?");
            Write(">>: ");
            string userIn = ReadLine();

            try
            {                
                var res = Enum.Parse(typeof(EWeekDays), userIn);
                WriteLine($"The current day of the week is: {res}");
            }
            catch (ArgumentNullException ex)
            {
                WriteLine("Argument Null Exception");
                WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                WriteLine("Argument Exception");
                WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                WriteLine("Overflow Exception");
                WriteLine(ex.Message);
            }

            ReadKey();
        }
    }
}
