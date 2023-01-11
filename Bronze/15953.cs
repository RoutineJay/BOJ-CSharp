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
                string[] s1 = Console.ReadLine().Split();
                int n = int.Parse(s1[0]);
                int m = int.Parse(s1[1]);
                int sum = 0;

                if (n == 1)
                    sum = sum + 5000000;
                else if (n >= 2 && n <= 3)
                    sum = sum + 3000000;
                else if (n >= 4 && n <= 6)
                    sum = sum + 2000000;
                else if (n >= 7 && n <= 10)
                    sum = sum + 500000;
                else if (n >= 11 && n <= 15)
                    sum = sum + 300000;
                else if (n >= 16 && n <= 21)
                    sum = sum + 100000;

                if (m == 1)
                    sum = sum + 5120000;
                else if (m >= 2 && m <= 3)
                    sum = sum + 2560000;
                else if (m >= 4 && m <= 7)
                    sum = sum + 1280000;
                else if (m >= 8 && m <= 15)
                    sum = sum + 640000;
                else if (m >= 16 && m <= 31)
                    sum = sum + 320000;

                sb.AppendLine(sum.ToString());
            }

            Console.Write(sb);
            
            
        }
    }
}