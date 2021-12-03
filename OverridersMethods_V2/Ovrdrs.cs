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

    }
}
