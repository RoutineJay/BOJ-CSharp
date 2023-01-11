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
            string[] s = Console.ReadLine().Split(' ');
            BigInteger n = BigInteger.Parse(s[0]);
            BigInteger m = BigInteger.Parse(s[1]);

            Console.WriteLine(n / m);
            Console.WriteLine(n % m);



        }
    }
}