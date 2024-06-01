using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USER_INPUT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();
            Console.WriteLine("Where do you live in?");
            string userLocation = Console.ReadLine();

            Console.WriteLine("Your name is " + userName);
            Console.WriteLine("Your age is " + userAge);
            Console.WriteLine("You live in " + userLocation);

            Console.ReadKey();
        }
    }
}
