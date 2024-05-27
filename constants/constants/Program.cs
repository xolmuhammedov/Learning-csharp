using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constants = immutable values which are known at compile time
            //             and do not change for the life of a program

            int numbers = 100;
            numbers = 120;
            Console.WriteLine(numbers); // in this case our integer is changed

            //CONST
            const int max = 100;
            //max = 101;                   // ERROR IS HERE
            Console.WriteLine(max); // the max cannot be changed because it is CONSTANT

            Console.ReadLine();
        }
    }
}
