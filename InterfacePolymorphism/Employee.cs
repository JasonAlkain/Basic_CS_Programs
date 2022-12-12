using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
    class Employee : Person, IQuittable
    {
        /// <summary>
        /// "Say my name." - Walter
        /// </summary>
        public override void SayName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        
        // Should the employee choose to quit...
        public void Quit()
        {
            Console.WriteLine("You can't quit, you're fired.");
        }
    }
}
