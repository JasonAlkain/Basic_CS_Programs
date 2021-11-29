using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Of_Arrays
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Variables
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Index tracker
        static int index = 0;
        // Borders
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



        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Functions
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {
            StringAryFunc();

            IntAryFunc();

            StringListFunc();
        }

        /// <summary>
        /// Simple bottom border and program catch.
        /// </summary>
        static void BottomBorder()
        {
            WriteLine($"{border}");
            ReadKey();
            Clear();
        }

        /// <summary>
        /// String Array Function
        /// </summary>
        static void StringAryFunc()
        {
            // Create the list
            string[] alpha_ary = {
                "\t\"Two things are infinite:\n\tthe universe and human stupidity;\n\tand I'm not sure about the universe.\" \n\t- Albert Einstein",
                "\t\"Live as if you were to die\n\ttomorrow. Learn as if you were\n\tto live forever.\" \n\t- Mahatma Gandhi",
                "\t\"There's no crying in baseball!\" \n\t- A League of Their Own, 1992",
                "\t\"May the Force be with you.\" \n\t- Star Wars"
            };


            WriteLine($"{border}");
            WriteLine($"  {border_S}");
            WriteLine("     String Array Function");
            WriteLine($"  {border_S}");
            //Prompt the user
            WriteLine($"Enter a number between 0 and {alpha_ary.Length-1}.");
            Write(">>: ");

            //Try to parse to a number
            int.TryParse(ReadLine(), out index);

            // Handle if index is in range
            if (index < alpha_ary.Length && index >= 0)
            {
                WriteLine($"{alpha_ary[index]}");
                BottomBorder();
            }
            else
            {
                WriteLine("Out of index");
                BottomBorder();
                StringAryFunc();
            }
        }

        /// <summary>
        /// Integer Array Function
        /// </summary>
        static void IntAryFunc()
        {
            // Create the list
            int[] beta_ary = { 0, 1, 22, 333, 4444, 55555, 666666 };


            WriteLine($"{border}");
            WriteLine($"  {border_S}");
            WriteLine("     Integer Array Function");
            WriteLine($"  {border_S}");
            //Prompt the user
            WriteLine($"Enter a number between 0 and {beta_ary.Length-1}.");
            Write(">>: ");

            //Try to parse to a number
            int.TryParse(ReadLine(), out index);

            // Handle if index is in range
            if (index < beta_ary.Length && index >= 0)
            {
                WriteLine($"\t{beta_ary[index]}");
                BottomBorder();
            }
            else
            {
                WriteLine("Out of index");
                BottomBorder();
                StringAryFunc();
            }
        }

        /// <summary>
        /// String List Function
        /// </summary>
        static void StringListFunc()
        {
            // Create the list
            List<string> alpha_list = new List<string>();

            // Create the list (not efficient but works)
            alpha_list.Add("Star Wars, 1977");
            alpha_list.Add("The Wizard of Oz, 1939");
            alpha_list.Add("Titanic, 1997");
            alpha_list.Add("Dead Poets Society, 1989");
            alpha_list.Add("The Adventures of Sherlock Holmes, 1939");
            alpha_list.Add("Frankenstein, 1931");
            alpha_list.Add("The Terminator, 1984");



            WriteLine($"{border}");
            WriteLine($"  {border_S}");
            WriteLine("     String List Function");
            WriteLine($"  {border_S}");
            //Prompt the user
            WriteLine($"Enter a number between 0 and {alpha_list.Count-1}.");
            Write(">>: ");

            //Try to parse to a number
            int.TryParse(ReadLine(), out index);

            // Handle if index is in range
            if (index < alpha_list.Count && index >= 0) { 
                WriteLine($"\t{alpha_list[index]}");
                BottomBorder();
            }
            else
            {
                WriteLine("Out of index");
                BottomBorder();
                StringAryFunc();
            }

        }
    }
}
