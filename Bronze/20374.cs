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
            StringBuilder sb = new StringBuilder();

            BigInteger a = 0;
            BigInteger b = 0;

            while(true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s) == true)
                    break;

                string[] s1 = s.Split('.');
                BigInteger a1 = BigInteger.Parse(s1[0]);
                BigInteger b1 = BigInteger.Parse(s1[1]);

                a = a + a1;
                b = b + b1;

                if (b >= 100)
                {
                    b = b - 100;
                    a++;
                }
            }

            string a2 = a.ToString();
            string b2 = b.ToString();

            if (b2.Length == 1)
                b2 = "0" + b2;

            Console.WriteLine($"{a2}.{b2}");
            
            

        }
    }
}