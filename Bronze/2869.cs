using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

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

            string[] s = sr.ReadLine().Split(' ');
            decimal a = decimal.Parse(s[0]); // 올라감
            decimal b = decimal.Parse(s[1]); // 미끄러짐
            decimal v = decimal.Parse(s[2]); // 목표

            decimal sum = a - b;
            decimal sum2 = v / sum;

            if (sum2 % sum == 0) 
            {
                sum2 = Math.Abs(sum2 - (b / sum));
            }
            else
            {
                sum2 = Math.Abs(Math.Ceiling(sum2 - (b / sum)));
            }

            sw.WriteLine(sum2);
        }
    }
}
