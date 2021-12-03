using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethods
{
    public class Overriders
    {
        public int rndNum = new Random().Next(1, 21);

        public Overriders() { }

        public int Responder(int UserIn)
        {
            return rndNum * UserIn;
        }

        public int Responder(decimal UserIn)
        {
            return (int)Math.Round(rndNum / UserIn);
        }

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
