using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridersMethods_V2
{
    public class Ovrdrs
    {
        public Ovrdrs()
        {

        }

        /// <summary>
        /// Takes two parameters and uses the modulus operation on them.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number. (Default: 2) </param>
        /// <returns></returns>
        public int MathThings(int a, int b = 2) => a % b;

        public void DisplaySecond(int a, int b)
        {
            double _A = Math.Sin(a);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"Math.Sin({a}) = {_A}");
            Console.WriteLine($"{b} * Math.Sin({a}) = {b * _A}");
        }

        public void DividerByTwo(int a, out int b) => b = a / 2;

    }
}
