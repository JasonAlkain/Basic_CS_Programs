using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    public class Alpha
    {
        public int Number { get; set; }

        public Alpha() => Number = new Random().Next(1001, 9999);

        public int Add(int num) => Number + num;

        public int Subtract(int num) => Number - num;

        public int Multiply(int num) => Number * num;
    }
}
