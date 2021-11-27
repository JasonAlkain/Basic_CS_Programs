using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Top border
            Console.WriteLine("<====================================================================>\n");

            // Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            // Divider
            Console.WriteLine("\n>==============================<");
            
            //
            Package _Package = GetPackageInfo();

            // Divider
            Console.WriteLine("\n>==============================<");
            //
            Console.WriteLine(
                "Your estimated total for shipping this package is: "+
                $"{_Package.CostQuote()}\n"+
                "Thank you!"
                );


            // Top border
            Console.WriteLine("\n<====================================================================>\n");

            Console.ReadKey();
        }


        static Package GetPackageInfo()
        {            
            // Request the package weight
            Console.Write("\nPlease enter the package weight:\n>>: ");
            float.TryParse(Console.ReadLine(), out float weight);

            // Check if package weight is less than 50
            // else throw 'out of range' error and terminate progam
            if (weight > 50)
            {
                Console.WriteLine(
                    "Package too heavy to be shipped via Package Express."+
                    "Have a good day."
                    );
                throw new ArgumentOutOfRangeException(
                    paramName: "weight", 
                    message: "The variable 'weight' should not exceed 50."
                    );
            }

            // Request the package width
            Console.Write("\nPlease enter the package width:\n>>: ");
            float.TryParse(Console.ReadLine(), out float width);

            // Request the package height
            Console.Write("\nPlease enter the package height:\n>>: ");
            float.TryParse(Console.ReadLine(), out float height);

            // Request the package length
            Console.Write("\nPlease enter the package length:\n>>: ");
            float.TryParse(Console.ReadLine(), out float length);

            // Calculate package dimensions
            float packageSize = (width + height + length);

            // Check if package dimensions are smaller than 50
            // else throw 'out of range' error and terminate progam
            if (packageSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                throw new ArgumentOutOfRangeException(
                    paramName: "packageSize", 
                    message: "The total dimensions 'width + height + length' should not exceed 50."
                    );

            }

            Console.WriteLine("\n>==========<");
            // Return a new Package obect from the user inputs
            return new Package(weight, width, height, length);
        }


    }

    /// <summary>
    /// Simple package class. Holds package weight, width, height, and length
    /// </summary>
    class Package
    {
        public float _Weight;
        public float _Width;
        public float _Height;
        public float _Length;

        public Package()
        {
            _Weight = 0;
            _Width = 0;
            _Height = 0;
            _Length = 0;
        }

        public Package(float weight, float width, float height, float length)
        {
            _Weight = weight;
            _Width = width;
            _Height = height;
            _Length = length;
        }

        /// <summary>
        /// Calculates the estimated cost to ship item.
        /// </summary>
        /// <returns>
        /// Estimated total for shipping this package.
        /// </returns>
        public float CostQuote() =>
            ((_Width * _Height * _Length) * _Weight) / 100;
    }
}
