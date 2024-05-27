using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TYPECASTING = converting a value to diffrent datatype
            //               Useful we when accpet user input (string)
            //               Diffrenet datatypes can do diffrent things

            double a = 3.14;
            int b = Convert.ToInt32(a); // converting to INTEGER
            Console.WriteLine(b.GetType());

            int c = 123;
            double d  = Convert.ToDouble(c) + 0.1;
            Console.WriteLine(d.GetType());
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");

            Console.ReadKey();
        }
    }
}
