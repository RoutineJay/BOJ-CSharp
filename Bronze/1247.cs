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
            for(int i=0; i<3; i++)
            {
                string s = Console.ReadLine();
                int a = int.Parse(s);
                BigInteger b = 0;

                for(int j=0; j<a; j++)
                {
                    string s1 = Console.ReadLine();
                    BigInteger b1 = BigInteger.Parse(s1);

                    b = b + b1;
                }

                if (b == 0)
                    Console.WriteLine(0);
                else if (b < 0)
                    Console.WriteLine("-");
                else if (b > 0)
                    Console.WriteLine("+");
            }
        }
    }
}