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
            //String fullName = "Bro Code";
            //String phonenumber = "123-456-7890";
            //phonenumber = phonenumber.Replace("-", "/");
            //Console.WriteLine(phonenumber);
            //int employeeId = 10;
            int phonenumber = 10;
            switch (phonenumber)
            {
                case 1:
                    Console.WriteLine(false);
                    break;
                case 10:
                    Console.Write(true);
                    break;
                    default:
                    Console.WriteLine("Unkown");
                    break;
            }

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            
            Console.ReadKey();
        }
    }
}
