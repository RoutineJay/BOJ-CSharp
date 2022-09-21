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
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;

            string s1 = sr.ReadLine();
            int a = int.Parse(s1);
            string s2 = sr.ReadLine();
            int b = int.Parse(s2);
            string s3 = sr.ReadLine();
            int c = int.Parse(s3);
            string s4 = sr.ReadLine();
            int d = int.Parse(s4);

            if(a < b && b < c && c < d)
            {
                sw.WriteLine("Fish Rising");
            }
            else if (a > b && b > c && c > d)
            {
                sw.WriteLine("Fish Diving");
            }
            else if (a == b && b == c && c == d)
            {
                sw.WriteLine("Fish At Constant Depth");
            }
            else
            {
                sw.WriteLine("No Fish");
            }
        }
    }
}