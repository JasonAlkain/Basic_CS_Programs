using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampda_Project
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
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Methods
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Random rnd = new Random();
            List<Employee> employees = new List<Employee>();

            List<String> FirstNames = new List<string>() {
                "Joe", "Zach", "Mike", "Paul", "David", "Steve",
                "Adam"
            };
            List<String> LastNames = new List<string>() {
                "Dirt", "Aars", "Smith", "Thompson", "Jones", "Miller",
                "Brown", "Clark", "White", "Harris"
            };

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Add new employees
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // insurance of more than one Joe
            employees.Add(
                new Employee()
                {
                    Id = rnd.Next(1, 10),
                    FirstName = "Joe",
                    LastName = "Dirt"
                }
                );

            // for loop to add random names
            for (int i = 2; i < 10; i++)
            {
                employees.Add(
                    new Employee()
                    {
                        Id = rnd.Next(1, 10),
                        FirstName = FirstNames[rnd.Next(0, 6)],
                        LastName = LastNames[rnd.Next(0, 9)]
                    }
                    );
            }
            // insurance of more than one Joe
            employees.Add(
                new Employee()
                {
                    Id = rnd.Next(1, 10),
                    FirstName = "Joe",
                    LastName = "Smith"
                }
                );

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // The whole List
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WriteLine("~~ Original List ~~");
            employees.ForEach(e => WriteLine($"# {e.Id}: {e.FirstName} {e.LastName}"));

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // First name check
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WriteLine("");
            WriteLine("~~ Joe List ~~");
            List<Employee> Joe_Emps = new List<Employee>();
            // Create a new list from employees where first name is Joe
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                    Joe_Emps.Add(emp);
            }
            Joe_Emps.ForEach(e => WriteLine($"# {e.Id}: {e.FirstName} {e.LastName}"));



            WriteLine("");
            WriteLine("~~ Joe List ~~");
            //[Alt] Create a new list from employees where first name is Joe
            Joe_Emps = new List<Employee>(employees.Where(e => e.FirstName == "Joe"));
            Joe_Emps.ForEach(e => WriteLine($"# {e.Id}: {e.FirstName} {e.LastName}"));

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Id Check
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WriteLine("");
            WriteLine("~~ ID Greater than 5 List ~~");
            List<Employee> New_Emps = new List<Employee>(employees.Where(e => e.Id > 5));
            New_Emps.ForEach(e => WriteLine($"# {e.Id}: {e.FirstName} {e.LastName}"));
            ReadKey();
        }
    }

    public struct Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
