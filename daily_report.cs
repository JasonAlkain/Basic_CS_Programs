using System;

class Program
{
    // Variable to save student name
    public static string studentName;
    // Var to save course name
    public static string courseName;
    // Var to save page number
    public static int pageNum = 0;
    // Var to save if the student needed help
    public static bool needHelp = false;
    // Var to save the positive experiences from the student
    public static string shareExp;
    // Var to save the feedback from the study
    public static string feedback;
    // Var to save the hours of study
    public static float studyHr = 0.0f;

    // The main entry point of the program
    public static void Main()
    {
        // Temporary variable for converting
        string _ = ""; // This should be cleaned up by the garbage colector.
        // Intro for the program
        Console.WriteLine("The Tech Academy.");
        Console.WriteLine("Student Daily Report.");

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
        pageNum = int.Parse(_);

        // Asks the user if they needed halp
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
        // Save the input
        _ = Console.ReadLine().ToLower();
        needHelp = (_ == "true") ? true : false;

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
        studyHr = float.Parse(Console.ReadLine());

        // Outro message

        // Return the user input to them
        Console.WriteLine("\n|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
        Console.WriteLine($"| studentName: {studentName} ");
        Console.WriteLine($"| courseName: {courseName} ");
        Console.WriteLine($"| pageNum: {pageNum} ");
        Console.WriteLine($"| needHelp: {needHelp} ");
        Console.WriteLine($"| shareExp: {shareExp} ");
        Console.WriteLine($"| feedback: {feedback} ");
        Console.WriteLine($"| studyHr: {studyHr} ");
        Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n");

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        // Prevent the progam from closing early...
        Console.ReadLine();
    }
}