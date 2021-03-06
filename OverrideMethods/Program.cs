using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethods
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


        static void Main(string[] args)
        {
            Overriders ovrdrs = new Overriders();
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // INTRO
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WriteLine(border);
            WriteLine($"    {border_S}");

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Integer override example
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WriteLine("\tInteger as parameter:");
            WriteLine($"\t  {ovrdrs.rndNum} * 5 = {ovrdrs.Responder(5)}");
            WriteLine($"    {border_S}");

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Decimal override example
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WriteLine("\tDecimal as parameter:");
            WriteLine($"\t  {ovrdrs.rndNum} / 5.5m = {ovrdrs.Responder(5.5m)}");
            WriteLine($"    {border_S}");

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // String override example
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Without error
            WriteLine("\tString as parameter:");
            WriteLine($"\t  {ovrdrs.rndNum} + \"5\" = {ovrdrs.Responder("5")}");

            // With error
            WriteLine("\tString as parameter: (With error message)");
            WriteLine($"\t  {ovrdrs.rndNum} + \"A\" = {ovrdrs.Responder("A")}");
            WriteLine($"    {border_S}");

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // OUTRO
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WriteLine(border);

            ReadKey();
        }
    }
}
