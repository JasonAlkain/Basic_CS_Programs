using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_And_Time
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
            // This is the date and time... well... now...
            // "It's simple spell but quite unbreakable" - Dr. Strange
            WriteLine($"{DateTime.Now}");
            // Meme? I don't know I don't really get it. But maybe it's funny?
            WriteLine("I am once again asking you for a number.");
            // Flare to make it look nice
            Write(">>: ");
            // either you get a number or you get 0
            int.TryParse(ReadLine(), out int userIn);

            // Clears the screen
            // BUT only if you uncomment it...
            // Clear();

            // Respond
            WriteLine("\nSilly me I forgot to tell you why here is the hours we skipped ahead.");

            // Print DateTime.Now with the added hours from the user.
            WriteLine($"{DateTime.Now.AddHours(userIn)}");


            // End of the road. (or program in this case)
            ReadKey();
        }
    }
}
