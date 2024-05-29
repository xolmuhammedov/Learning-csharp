using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learning_something
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            int someNum = 1001;
            Console.WriteLine(Convert.ToString(someNum));

            double num = 15;
            Console.WriteLine(num);
            while (num <= 20)
            {
                Console.WriteLine(num);
                num++;
            }

            int weather = 1;
            switch (weather)
            {
                case 2:
                    Console.WriteLine("Take your umbrella");
                    break;

                case 1:
                    Console.WriteLine("Wear more clother cuz it is snowy");
                    break;

                default:
                    Console.WriteLine("Unknown weather");
                    break;
            }

            string greetings = "Hello";
            Console.WriteLine(greetings + " MuhammadYusuf" + "What is your major");

            Console.ReadKey();
        }
    }
}
