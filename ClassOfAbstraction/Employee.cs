using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOfAbstraction
{
    public class Employee : Person
    {
        // Override from Person to say name.
        public override void SayName() => Console.Write($"{FirstName} {LastName}");
    }
}
