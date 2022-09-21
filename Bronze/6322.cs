using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;
            int count = 1;
            while(true)
            {
                string s = sr.ReadLine();
                if (s == "0 0 0")
                    break;

                string[] s1 = s.Split();
                string s2 = null;
                double a = double.Parse(s1[0]);
                if (a == -1)
                    s2 = "a";
                double b = double.Parse(s1[1]);
                if (b == -1)
                    s2 = "b";
                double c = double.Parse(s1[2]);
                if (c == -1)
                    s2 = "c";

                if(s2 == "a")
                {
                    a = Math.Sqrt(c * c - b * b);

                    if(a + b > c)
                    {
                        sw.WriteLine($"Triangle #{count}");
                        sw.WriteLine("a = {0:F3}", a);
                    }
                    else
                    {
                        sw.WriteLine($"Triangle #{count}");
                        sw.WriteLine("Impossible.");
                    }
                }
                else if (s2 == "b")
                {
                    b = Math.Sqrt(c * c - a * a);

                    if (a + b > c)
                    {
                        sw.WriteLine($"Triangle #{count}");
                        sw.WriteLine("b = {0:F3}", b);
                    }
                    else
                    {
                        sw.WriteLine($"Triangle #{count}");
                        sw.WriteLine("Impossible.");
                    }    
                }
                else if (s2 == "c")
                {
                    c = Math.Sqrt(a * a + b * b);

                    if (a + b > c)
                    {
                        sw.WriteLine($"Triangle #{count}");
                        sw.WriteLine("c = {0:F3}", c);
                    }
                    else
                    {
                        sw.WriteLine($"Triangle #{count}");
                        sw.WriteLine("Impossible.");
                    }
                }

                count++;
                sw.WriteLine();
            }
        }
    }
}