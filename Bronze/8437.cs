using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            BigInteger a1 = BigInteger.Parse(s1);
            string s2 = Console.ReadLine();
            BigInteger b1 = BigInteger.Parse(s2);

            Console.WriteLine((a1+b1)/2);
            Console.WriteLine((a1-b1)/2);



        }
    }
}