using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; // Biginteger
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string s = Console.ReadLine();
            int a = int.Parse(s);

            if(a == 0)
            {
                Console.WriteLine(" * * *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine(" * * *");
            }

            if (a == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("");
            }

            if (a == 2)
            {
                Console.WriteLine(" * * *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine(" * * *");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine(" * * *");
            }

            if (a == 3)
            {
                Console.WriteLine(" * * *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine(" * * *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine(" * * *");
            }

            if (a == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine(" * * *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("");
            }

            if (a == 5)
            {
                Console.WriteLine(" * * *");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine(" * * *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine(" * * *");
            }

            if (a == 6)
            {
                Console.WriteLine(" * * *");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine("*");
                Console.WriteLine(" * * *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine(" * * *");
            }

            if (a == 7)
            {
                Console.WriteLine(" * * *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("");
            }

            if (a == 8)
            {
                Console.WriteLine(" * * *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine(" * * *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine(" * * *");
            }

            if (a == 9)
            {
                Console.WriteLine(" * * *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine(" * * *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine("      *");
                Console.WriteLine(" * * *");
            }

        }
    }
}