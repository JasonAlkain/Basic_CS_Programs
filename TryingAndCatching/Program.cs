using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingAndCatching
{
    class Program
    {
        // Initialize the list
        public static List<int> vs = new List<int> { 128, 256, 512, 1024, 2048, 4096, 8192, 16348 };

        // List of errors
        public static List<string> errorsLog = new List<string>();

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Fun lambda experiments to reduce some code
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(string s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();


        static void Main(string[] args)
        {
            TryCatcher();

            ReadKey();
        }

        static void TryCatcher()
        {
            // Create a string from the list
            StringBuilder sb = new StringBuilder();
            vs.ForEach(n => sb.Append($" {n} "));
            
            // Print the initial list
            WriteLine(sb.ToString());

            // Prompt the user for a number
            WriteLine("Enter a number to divide the above list by.");
            Write(">>: ");
            try
            {
                int userIn = Convert.ToInt32(ReadLine());
                vs.ForEach(n => WriteLine($"{n} / {userIn} = {n / userIn}"));
            }
            catch (DivideByZeroException ex)
            {
                WriteLine("I can not divide by zero.");
                errorsLog.Add($"Index at: {errorsLog.Count} | {ex.Message}");
                ReadKey();
                Clear();
                TryCatcher();
            }
            catch (FormatException ex)
            {
                WriteLine("You must enter a whole number.");
                errorsLog.Add($"Index at: {errorsLog.Count} | {ex.Message}");
                ReadKey();
                Clear();
                TryCatcher();
            }
            finally
            {
                sb = new StringBuilder();
                errorsLog.ForEach(e => sb.Append($"{e}\n"));
            }

            WriteLine(sb.ToString());
            ReadKey();
            Clear();

        }
    }
}
