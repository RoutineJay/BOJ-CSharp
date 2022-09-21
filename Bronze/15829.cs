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
        static BigInteger jegob(BigInteger a)
        {
            BigInteger sum = 1;

            if (a == 0)
                return 1;
            else
            {
                for (BigInteger i = 0; i < a; i++)
                    sum = sum * 31;

                return sum;
            }
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;

            string s = sr.ReadLine();
            int a = int.Parse(s);

            string s1 = sr.ReadLine();
            char[] c = s1.ToCharArray();
            BigInteger sum = 0;

            for (int i = 0; i < a; i++)
            {
                if (c[i] == 'a')
                    sum = sum + 1 * jegob(i);
                else if (c[i] == 'b')
                    sum = sum + 2 * jegob(i);
                else if (c[i] == 'c')
                    sum = sum + 3 * jegob(i);
                else if (c[i] == 'd')
                    sum = sum + 4 * jegob(i);
                else if (c[i] == 'e')
                    sum = sum + 5 * jegob(i);
                else if (c[i] == 'f')
                    sum = sum + 6 * jegob(i);
                else if (c[i] == 'g')
                    sum = sum + 7 * jegob(i);
                else if (c[i] == 'h')
                    sum = sum + 8 * jegob(i);
                else if (c[i] == 'i')
                    sum = sum + 9 * jegob(i);
                else if (c[i] == 'j')
                    sum = sum + 10 * jegob(i);
                else if (c[i] == 'k')
                    sum = sum + 11 * jegob(i);
                else if (c[i] == 'l')
                    sum = sum + 12 * jegob(i);
                else if (c[i] == 'm')
                    sum = sum + 13 * jegob(i);
                else if (c[i] == 'n')
                    sum = sum + 14 * jegob(i);
                else if (c[i] == 'o')
                    sum = sum + 15 * jegob(i);
                else if (c[i] == 'p')
                    sum = sum + 16 * jegob(i);
                else if (c[i] == 'q')
                    sum = sum + 17 * jegob(i);
                else if (c[i] == 'r')
                    sum = sum + 18 * jegob(i);
                else if (c[i] == 's')
                    sum = sum + 19 * jegob(i);
                else if (c[i] == 't')
                    sum = sum + 20 * jegob(i);
                else if (c[i] == 'u')
                    sum = sum + 21 * jegob(i);
                else if (c[i] == 'v')
                    sum = sum + 22 * jegob(i);
                else if (c[i] == 'w')
                    sum = sum + 23 * jegob(i);
                else if (c[i] == 'x')
                    sum = sum + 24 * jegob(i);
                else if (c[i] == 'y')
                    sum = sum + 25 * jegob(i);
                else if (c[i] == 'z')
                    sum = sum + 26 * jegob(i);
            }

            BigInteger sum2 = sum % 1234567891;

            sw.WriteLine(sum2);


        }
    }
}