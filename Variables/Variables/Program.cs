using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String greeting; // decloration of variable;
            greeting = "Hello World!"; // initialization of variable;
            Console.WriteLine(greeting);

            int firstNum = 100; // whole INTEGER
            Console.WriteLine("Hello can i take " + firstNum + " $");

            double someNumber = 300.5; // decimal NUMBER
            Console.WriteLine("Your height is " + someNumber + "cm");

            bool alive = true; // boolean = TRUE or FALSE
            Console.WriteLine("Are you alive?\n Yes that is " + alive );

            char symbol = '@'; // char for SYMBOLS only in single quote
            Console.WriteLine("Your symbol is: " + symbol);

            String text = "Document"; // string datatype
            Console.WriteLine("Do you have any " + text + " ?");
            Console.ReadLine();

        }
    }
}
