using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Varables
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // borders
        static string border = "<=============================================>";
        static string border_S = ">=========================<";
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Fun lambda experiments to reduce some code
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(string s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();
        static void ClearScreen()
        {
            ReadKey();
            Clear();
        }

        public static Alpha alpha = new Alpha();

        static void Main(string[] args)
        {
            Intro();
            Outro();

            ReadKey();
        }


        static void Intro()
        {

            WriteLine(border);
            WriteLine("The computer will atempt to proform the following actions:");
            WriteLine("addition, subtraction, and multiplication\n");
            // Prompt user for input
            WriteLine("Enter a number with no more than three digits.");
            Write(">>: ");
            // Try to parse the input as an integer
            //int.TryParse(ReadLine(), out int userIn);
            Checker(ReadLine(), alpha);

        }

        static void Outro()
        {
            WriteLine(border);
            WriteLine("\nThank you for using my program even though it is simple.\n");
            WriteLine(border);
        }

        static void Checker(string userIn, Alpha alpha)
        {
            try
            {
                int result = Convert.ToInt32(userIn);

                if (result > 999)
                {
                    WriteLine("You must enter a number with no more than three digits.");
                    ClearScreen();
                    Intro();
                }
                else if (result < 0)
                {
                    WriteLine("You must enter a number greater than 0.");
                    ClearScreen();
                    Intro();
                }
                else
                {
                    WriteLine(border_S);
                    WriteLine($"{alpha.Number} + {userIn} = {alpha.Add(result)}\n");
                    WriteLine($"{alpha.Number} - {userIn} = {alpha.Subtract(result)}\n");
                    WriteLine($"{alpha.Number} * {userIn} = {alpha.Multiply(result)}\n");
                    WriteLine(border_S);
                }

            }
            catch (FormatException ex)
            {
                WriteLine("You must enter a number.");
                WriteLine(border_S);
                ClearScreen();
                Intro();
            }
            finally
            {

            }

        }
    }
}
