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

            for(int i=0; i<a; i++)
            {
                string s1 = Console.ReadLine();
                BigInteger b = BigInteger.Parse(s1);
                BigInteger c = b * b;

                sb.AppendLine(c.ToString());
            }

            Console.Write(sb);

        }
    }
}