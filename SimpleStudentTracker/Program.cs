using System;

namespace SimpleStudentTracker
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
        // Variables
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public static string version = "v 0.1.0";

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Methods
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {
            WriteLine("~Student Grade Tracking~");
            WriteLine($"[ Console Release {version} ]");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");


            using (var ctx = new SchoolContext())
            {
                var student = new Student();
                WriteLine("Please enter the students name.");
                Write(">>: ");
                student.StudentName = ReadLine();
                WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

                WriteLine("Great!");
                WriteLine("Let's just just add him to the list...\n");
                ctx.Students.Add(student);
                WriteLine($"~ Added {student.StudentName}\n");
                WriteLine($"~ Saving Changes...\n");
                ctx.SaveChanges();
                WriteLine($"~ Changes Saved!\n");
                WriteLine("\n");
                WriteLine("Alright, that should do it.");
                WriteLine("\n\n");
                WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                var studentsList = ctx.Students;
                WriteLine("Here are all the students we have so far:");
                foreach (var stud in studentsList)
                {
                    WriteLine($"\t{stud.StudentName}");
                }
            }


            Console.ReadKey();
        }
    }

}
