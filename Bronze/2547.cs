using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            BigInteger a = BigInteger.Parse(s);
            BigInteger a1 = 0;

            for(int i=0; i<a; i++)
            {
                string s1 = Console.ReadLine();
                if (string.IsNullOrEmpty(s1) == false)
                    a1 = BigInteger.Parse(s1);
                else
                {
                    string s2 = Console.ReadLine();
                    a1 = BigInteger.Parse(s2);
                }
                    
                BigInteger sum = 0;

                for(int j=0; j<a1; j++)
                {
                    string s2 = Console.ReadLine();
                    BigInteger a2 = BigInteger.Parse(s2);
                    sum = sum + a2;
                }

                if (sum % a1 == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

        }
    }
}
