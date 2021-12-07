using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Simplifiers for Console 'I/O'
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(string s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Methods
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {
            // New employee
            Employee em_1 = new Employee()
            {
                FirstName = "Walter",
                LastName = "[NOT_FOUND]"
            };

            // Say Hello
            em_1.SayName();

            // Object of the interface from the employee class
            IQuittable quitter = new Employee();

            // Now quit
            quitter.Quit();


            // Object of the interface from the employee object
            IQuittable qtr_2 = em_1;

            // This is the second version from an object
            qtr_2.Quit();

            // Jobs done
            ReadKey();
        }
    }
}
