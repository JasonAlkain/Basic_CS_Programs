using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridersMethods_V2
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Varables
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // borders
        static string border = "<=============================================>";
        static string border_S = ">=========================<";

        public static Ovrdrs ovrdrs = new Ovrdrs();


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Fun lambda experiments to reduce some code
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(string s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Functions
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {
            //MultipleParameters(ovrdrs);
            //MultipleParameters_V2(ovrdrs);
            OutputParameters(ovrdrs);

            ReadKey();     
        }

        static void MultipleParameters(Ovrdrs od)
        {

            WriteLine($"{border}");

            WriteLine("Let us take two numbers and perform the \"%\" operation on them.");
            WriteLine($"{border_S}");

            // Get user input and try to convert to number
            int _A = GetNumber();
            Clear();

            WriteLine($"{border}");
            WriteLine("WAIT!!");
            WriteLine("Before we get ahead of ourselves,");
            WriteLine("let's try that number on a \'2\'.");
            WriteLine("You know, to check things out...");
            Write("Press enter to continue...");
            ReadKey();
            loadingWheel();
            Clear();

            // With one
            WriteLine($"{border}");
            WriteLine($"{_A} % 2 = {od.MathThings(_A)}");
            WriteLine($"{border_S}");
            WriteLine("Alright! looking good!\n");
            WriteLine("Now for the second number.\n");
            WriteLine($"{border_S}");

            // Get user input and try to convert to number
            int _B = GetNumber(2);
            Clear();

            WriteLine($"{border_S}");
            WriteLine("Okay moment of truth...");
            WriteLine($"let's try {_A} and {_B} now.");
            WriteLine("Cross you fingers... And...");
            Write("Press enter to continue...");
            ReadKey();
            loadingWheel();
            Clear();

            // With Both
            WriteLine($"{border}");
            WriteLine($"{_A} % {_B} = {od.MathThings(_A, _B)}");

            WriteLine($"{border_S}");
            WriteLine("IT WORKED!!!");
            WriteLine("Great job out there!");
            WriteLine("You deserve a pat on the back!");
            Write("Press enter to continue... ");
            ReadKey();
            loadingWheel("*$#&^@%~!");


            WriteLine($"!!!  {border_S}  !!!");
            WriteLine("An error has occured.");
            WriteLine("Unable to load \"..\\gifs\\pat_on_back.gif\"");
            WriteLine($"!!!  {border_S}  !!!");
            Write("Press enter to continue... ");
            ReadKey();
            WriteLine($"{border_S}");
            WriteLine("Well... this is... um... awkward...");
            ReadKey();
            WriteLine("No worries though!");
            WriteLine("I just got word this will be fixed in post.");
            Write("Press enter to continue...");

        }

        static void MultipleParameters_V2(Ovrdrs od)
        {
            WriteLine(border);
            od.DisplaySecond(5, 15);
            WriteLine(border);
            od.DisplaySecond(b: 5, a: 15);
            WriteLine(border);
        }
        static void OutputParameters(Ovrdrs od)
        {
            // Get user input and 
            GetNumber(10, out int userIn);
            // Use the method...
            od.DividerByTwo(userIn, out int res);
            // Print results
            WriteLine($"{userIn} / 2 = {res}");
        }

        static int GetNumber(int minNum = 1)
        {
            int result = minNum;
            WriteLine($"Enter any whole number between {minNum} and 100.");
            Write(">>: ");
            // Get user input
            string userIn = ReadLine();

            // try to convert the string to a number
            try
            {
                result = Convert.ToInt32(userIn);
            }
            catch (FormatException ex)
            {
                WriteLine($"!!!  {border_S}  !!!");
                WriteLine($"An error has occured trying to convert your input.");
                WriteLine($"Please enter any whole number between {minNum} and 100.");
                WriteLine($"!!!  {border_S}  !!!");
                ReadKey();
                Clear();
            }
            finally { }
            return result;
        }
        static void GetNumber(int minNum, out int result)
        {
            result = 0;
            WriteLine($"Enter any whole number between {minNum} and 100.");
            Write(">>: ");
            // Get user input
            int.TryParse(ReadLine(), out int res);
            result = res;
        }


        static void loadingWheel(string ending = "|")
        {
            Write("\n|");
            ReadKey();
            Write("\b/");
            ReadKey();
            Write("-");
            ReadKey();
            Write("\\");
            ReadKey();
            Write(ending);
            ReadKey();

        }
    }
}
