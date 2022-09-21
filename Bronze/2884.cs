using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;

            string a, b;
            int c, d, clock, result;
            string[] str = Console.ReadLine().Split();
            a = str[0];
            b = str[1];
            c = int.Parse(a);
            d = int.Parse(b);

            d = d - 45;
            if (d < 0)
            {
                c = c - 1;
                d = d + 60;
                if (c < 0)
                {
                    c = 23;
                }
            }

            Console.WriteLine($"{c} {d}");
        }
    }
}