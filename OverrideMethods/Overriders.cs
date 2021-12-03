using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethods
{
    /// <summary>
    /// A series of override methods with a random number
    /// </summary>
    public class Overriders
    {
        public int rndNum { get; }


        /// <summary>
        /// Generates a new random number with definable min and max fields when instatiated.
        /// </summary>
        /// <param name="_Min">The minimum number for the generator. (Default: 7)</param>
        /// <param name="_Max">The maximum number for the generator. (Default: 21)</param>
        public Overriders(int _Min = 7, int _Max = 21) => rndNum = new Random().Next(_Min, _Max);


        /// <summary>
        /// Multiplies the random by the parameter
        /// </summary>
        /// <param name="UserIn">
        /// Parameter passed in for the math equation
        /// </param>
        /// <returns></returns>
        public int Responder(int UserIn) => rndNum * UserIn;
        
        
        /// <summary>
        /// Divides the random by the parameter
        /// </summary>
        /// <param name="UserIn">
        /// Parameter passed in for the math equation
        /// </param>
        /// <returns></returns>
        public int Responder(decimal UserIn) => (int)Math.Round(rndNum / UserIn);
        
        
        /// <summary>
        /// Adds the random by the parameter
        /// </summary>
        /// <param name="UserIn">
        /// Parameter passed in for the math equation
        /// </param>
        /// <returns></returns>
        public int Responder(string UserIn)
        {
            int result = 0;
            try
            {
                int userIn = Convert.ToInt32(UserIn);
                result = rndNum + userIn;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                result = -1;
            }
            finally { }

            return result;
        }

    }
}
