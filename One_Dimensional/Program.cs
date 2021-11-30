using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Dimensional
{
    class Program
    {
        // Borders
        static string border = "<=============================================>";
        static string border_S = ">=========================<";
        // User input storage
        static string userIn;


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
            // Uncomment to view
            UpdateArrayLoop();
            ReadKey();
            Clear();

            // Uncomment to view
            InfinateLoop();
            ReadKey();
            Clear();

            // Uncomment to view
            OperatorLoop();
            ReadKey();
            Clear();

            // Uncomment to view
            SearchList(false);
            ReadKey();
            Clear();

            // Uncomment to view
            PartSix();

            ReadKey();
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Search Lists...
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void PartSix()
        {
            // Create the list to search
            List<string> searcher = new List<string>() {
                "1977", "1939", "1997", "1989", "1939",
                "1931", "1984", "1997", "1989", "1931",
                "1984", "1997", "1989", "1931", "1984"
            };
            
            // The list of items found from the list to search
            List<string> found = new List<string>();


            // Loop through the list for matching items
            for (int i = 0; i < searcher.Count; i++)
            {
                if (searcher[i].Contains("1989"))
                {
                    // Add Items found to the found list
                    found.Add($"Indexed at: {i}");
                }
            }

            if (found.Count > 0)
                found.ForEach(item => WriteLine(item));
            else
                WriteLine("No items found.");

        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Search Lists...
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void SearchList(bool bBreak)
        {
            // Create the list
            List<string> searcher = new List<string>();
            List<string> found = new List<string>();


            // Create the list (not efficient but works)
            searcher.Add("Star Wars, 1977");
            searcher.Add("The Wizard of Oz, 1939");
            searcher.Add("Titanic, 1997");
            searcher.Add("Dead Poets Society, 1989");
            searcher.Add("The Adventures of Sherlock Holmes, 1939");
            searcher.Add("Frankenstein, 1931");
            searcher.Add("The Terminator, 1984");

            //Prompt the user
            WriteLine($"Search for a word in a movie. (example: The)");
            Write(">>: ");
            // get user input
            userIn = ReadLine();
            // Loop through the list for matching items
            foreach (string item in searcher)
            {
                if (item.Contains(userIn))
                {
                    // Add Items found to the found list
                    found.Add($"Index {searcher.IndexOf(item)}");
                    if (bBreak)
                        break;
                }

            }

            if (found.Count > 0)
                found.ForEach(item => WriteLine(item));
            else
                WriteLine("No items found.");

        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Operator loop.
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void OperatorLoop()
        {

            int count_to = 64;
            int counter = 0;

            //Prompt the user
            WriteLine($"How far should I count?");
            Write(">>: ");
            // get user input
            int.TryParse(ReadLine(), out count_to);

            for (int i = 0; i < count_to; i++)
                counter++;
            WriteLine($"Count to: {count_to}");
            WriteLine($"Counter (<): {counter}");

            // reset counter
            counter = 0;
            for (int i = 0; i <= count_to; i++)
                counter++;
            WriteLine($"Count to: {count_to}");
            WriteLine($"Counter (<=): {counter}");
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Infinate loop.
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void InfinateLoop()
        {
            // Fastest way to do this...
            while (true)
            {
                UpdateArrayLoop();
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Fix to infinate loop.
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                //Prompt the user
                WriteLine("Would you like to leave? [yes|no]");
                Write(">>: ");
                // get user input
                userIn = ReadLine().ToLower();
                // breaks the loop...
                if (userIn == "yes")
                    break;
                else
                    Clear();

            }

        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Update Array Loop
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void UpdateArrayLoop()
        {
            // Array setup
            string[] vs = { "Hello,", "It is a please to meet you,", "I hope you enjoy your visit,", "We are at your service," };

            //Prompt the user
            WriteLine($"What is your name?");
            Write(">>: ");
            // get user input
            userIn = ReadLine();

            // 
            for (int i = 0; i < vs.Length; i++)
                vs[i] = $"{vs[i]} {userIn}.";

            //
            foreach (string s in vs)
                WriteLine(s);

        }
    }
}
