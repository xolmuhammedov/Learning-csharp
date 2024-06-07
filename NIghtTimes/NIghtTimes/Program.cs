using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIghtTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Bro Code";
            String phonenumber = "123-456-7890";
            phonenumber = phonenumber.Replace("-", "/");
            Console.WriteLine(phonenumber);

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
