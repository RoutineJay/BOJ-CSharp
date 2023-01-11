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

            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            int c = 0;
            int d = 0;
            bool error = false;

            while (true)
            {
                if (a == 0)
                {
                    if (c + d != a && c - d != b)
                        error = true;
                    break;
                }

                if (c - d != b)
                {
                    c++;
                }
                else
                {
                    d++;
                }

                a--;
            }

            if (error == false)
                Console.WriteLine($"{c} {d}");
            else
                Console.WriteLine(-1);


        }
    }
}