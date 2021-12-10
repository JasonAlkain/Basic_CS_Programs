using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Constructor
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Simplifiers for Console 'I/O'
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(String s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Methods
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {
            const int MOD_ALL = 9;
            var rnd = new Random();
            int rnd_A = rnd.Next() % MOD_ALL;
            int rnd_B = rnd.Next() % MOD_ALL;

            // Based constructor
            var cc_A = new ChainedClass(rnd_A, rnd_B);
            // Chained constructor
            var cc_B = new ChainedClass(rnd_A + rnd_B);

            // Print results
            WriteLine("Not Chained:");
            WriteLine($"{cc_A.Alpha} | {cc_A.Beta}");
            WriteLine("Chained:");
            WriteLine($"{cc_B.Alpha} | {cc_B.Beta}");

            ReadKey();
        }
    }

    public class ChainedClass
    {
        public int Alpha { get; set; }
        public int Beta { get; set; }



        public ChainedClass(int alpha) : this(alpha, new Random().Next() % 9)
        {

        }

        public ChainedClass(int alpha, int beta)
        {
            Alpha = alpha;
            Beta = beta;
        }
    }
}
