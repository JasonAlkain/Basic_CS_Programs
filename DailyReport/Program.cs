using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        // Variable to save student name
        public static string studentName;
        // Var to save course name
        public static string courseName;
        // Var to save page number
        public static int pageNum = 0;
        // Var to save if the student needed help
        // Need help assumes help is needed
        public static bool needHelp = true;
        // Var to save the positive experiences from the student
        public static string shareExp;
        // Var to save the feedback from the study
        public static string feedback;
        // Var to save the hours of study
        public static float studyHr;

        // The main entry point of the program
        static void Main(string[] args)
        {
            // Temporary variable for converting
            string _ = ""; // This should be cleaned up by the garbage colector.

            // ***********************
            // Intro message
            // ***********************

            // Intro for the program
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            // ***********************
            // Questionare
            // ***********************

            // Asks the user their name.
            Console.WriteLine("What is your name?");
            // Save the input
            studentName = Console.ReadLine();

            // Asks the user for the course name
            Console.WriteLine("What course are you on?");
            // Save the input
            courseName = Console.ReadLine();

            // Asks the user for the page number their are on
            Console.WriteLine("What page number?");
            // Save the input
            _ = Console.ReadLine();
            // Try to parse user input into pageNum
            int.TryParse(_, out pageNum);

            // Asks the user if they needed halp
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            // Save the input
            _ = Console.ReadLine().ToLower();
            // Try to parse the user input into needHelp
            bool.TryParse(_, out needHelp);

            // Asks the user if they have any positive experiences
            Console.WriteLine("Were there any positive experiences you’d like to share?");
            // Save the input
            shareExp = Console.ReadLine();

            // Asks the user if they have any feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            // Save the input
            feedback = Console.ReadLine();

            // Asks the user for the amount of time studied in hours today.
            Console.WriteLine("How many hours did you study today?");
            // Save the input
            _ = Console.ReadLine();
            // Try to parse user input into studyHr
            float.TryParse(_, out studyHr);

            // ***********************
            // Outro message
            // ***********************

            // Return the user input to them
            Console.WriteLine("\n|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine($"| ~~~~~~~~~ Student Report ~~~~~~~~~ | ");
            Console.WriteLine($"| Student Name:      {studentName} ");
            Console.WriteLine($"| Course Name:       {courseName} ");
            Console.WriteLine($"| Page Num:          {pageNum} ");
            Console.WriteLine($"| In Need Help:      {needHelp} ");
            Console.WriteLine($"| Share Experiences: {shareExp} ");
            Console.WriteLine($"| Feedback:          {feedback} ");
            Console.WriteLine($"| Study Hour(s):     {studyHr} ");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n");

            // Final message message
            Console.WriteLine("Thank you for your answers.");
            Console.WriteLine("An Instructor will respond to this shortly.");
            Console.WriteLine("Have a great day!");

            // Prevent the progam from closing early...
            Console.ReadLine();
        }
    }
}
