using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLooper
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Varables
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // borders
        static string border = "  <=============================================>";
        static string border_S = "      >=========================<";
        // Try again message
        static string tryAgain = "\n\n\tPress enter to try again or 'q' to quit\n\t>>: ";
        // Atempt tracker
        static int atempts = 0;


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
            int num = new Random().Next(1, 101);
            bool isGuessed = false;

            do
            {
                // increament the number of atempts
                atempts++;
                // Clear the screen
                Clear();
                // Prompt the user for a number between 1 and 100
                WriteLine($"{border}");
                WriteLine("\tDave, I am thinking of a number.");
                Write("\tMy parameters are between 1 and 100.\n\t>>: ");
                // Try to parse the user input as an integer.
                int.TryParse(ReadLine(), out int userIn);
                // 
                if(userIn > 100 || userIn < 1)
                {
                    WriteLine("\tI'm sorry Dave, but that is outside my parameters...");
                    WriteLine("\tPlease enter a number between 1 and 100 next time...");
                    ReadKey();
                }
                else
                {
                    // Check if the user guessed the right number
                    // or tell them if it was too high/low of a guess
                    if (userIn == num)
                    {
                        // Display of the winning number and atempts
                        string times = atempts > 1 ? "times." : "time!";
                        WriteLine($"\n{border_S}");
                        WriteLine($"\n\tCongratulations Dave!!!");
                        WriteLine($"\n{border_S}");
                        WriteLine($"\tThe number was: {num}");
                        WriteLine($"\tYou tried: {atempts} {times}");
                        WriteLine($"{border_S}");
                        WriteLine($"\n\n{border}");
                        // A kind of pause break before moving on.
                        isGuessed = true;
                    }
                    else if (userIn > num) // Too high of a guess
                    {
                        WriteLine("\tYou guessed too high Dave...\n\tTry again?");
                        // Prompt the user if they want to quit
                        Write(tryAgain);
                        // If the user chooses to quit then break the loop
                        if (ReadLine().ToLower() == "q")
                            break;
                    }
                    else if (userIn < num) // Too low of a guess
                    {
                        WriteLine("\tYou guessed too low Dave...\n\tTry again?");
                        // Prompt the user if they want to quit
                        Write(tryAgain);
                        // If the user chooses to quit then break the loop
                        if (ReadLine().ToLower() == "q")
                            break;

                    }

                }


            }
            while (!isGuessed);

            Write($"{border}\n\n\tThank you for playing!\n\n{border}");
            ReadKey();
        }
    }


}
