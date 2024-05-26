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
            int firstNum = 100;
            Console.WriteLine("Hello can i take " + firstNum + " $");
            string[] words = { "hello", "hi"};
            object[] db = { firstNum , words };
            Console.WriteLine(words[0]);
            Console.WriteLine(db[1]);
            Console.ReadLine();

        }
    }
}
