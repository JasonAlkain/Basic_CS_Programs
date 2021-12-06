using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod_V5
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }

        /// <summary>
        /// Method to print the name of the person to the screen
        /// </summary>
        public void SayName() => Console.WriteLine($"Name: [{FirstName} {LastName}]");

    }
}
