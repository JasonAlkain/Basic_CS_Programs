using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApproval
{
    class Program
    {
        static Person person = new Person();

        static void Main(string[] args)
        {
            //=======================
            // Get applicant info
            //=======================

            // Create the upper border for readability
            Console.WriteLine("<===================================>");

            // Set the person info with the
            person = SetApplicantInfo(person);

            // Create the bottom border for readability
            Console.WriteLine("<===================================>");


            //=======================
            // Print if applicant is qualified
            //=======================

            // Create the upper border for readability
            Console.WriteLine("\n<===================================>");

            // Return if the applicant is qualified
            Console.WriteLine($"Qualified?\n{CheckApplicant(person)}");

            // Create the bottom border for readability
            Console.WriteLine("<===================================>");


            Console.ReadKey();
        }

        /// <summary>
        /// Request info from the applicant and return an object 
        /// </summary>
        /// <param name="applicant">
        /// The object that will be used to set the info.
        /// </param>
        /// <returns></returns>
        static Person SetApplicantInfo(Person applicant)
        {

            // Get the applicant age
            // if needed add code to:
            // - check if within an accaptable age range
            Console.WriteLine("What is your age?");
            int.TryParse(Console.ReadLine(), out applicant._Age);

            // Get the applicant DUI info
            // if needed add code to:
            // - check if response is 'yes', 'no', or 'other'
            // - if 'other' recycle question
            Console.WriteLine("Have you ever had a DUI? [yes|no]");
            string DUIResponse = Console.ReadLine().ToLower();
            applicant._HasDUI = DUIResponse == "yes" ? true : false;

            // Get the applicant number of speeding tickets. 
            Console.WriteLine("How many speeding tickets do you have?");
            int.TryParse(Console.ReadLine(), out applicant._SpeedingTickets);

            // future options? add a verification on information entered
            // and add a way to alow the option to re-enter information
            return applicant;
        }

        /// <summary>
        /// Check if the applicant is qualified and return true or false
        /// </summary>
        /// <param name="applicant"></param>
        /// <returns></returns>
        static bool CheckApplicant(Person applicant) => 
            (applicant._Age > 15 && 
            applicant._HasDUI == false && 
            applicant._SpeedingTickets <= 3);
    }

    /// <summary>
    ///  A simple Person class to hold information
    /// </summary>
    class Person
    {
        // Persons age
        public int _Age;
        // Has had a DUI 
        public bool _HasDUI;
        // Number of speeding tickets
        public int _SpeedingTickets;

        /// <summary>
        /// Simple constructor. Sets everything to '0' of 'false'.
        /// </summary>
        public Person()
        {
            _Age = 0;
            _HasDUI = false;
            _SpeedingTickets = 0;
        }
    }
}
