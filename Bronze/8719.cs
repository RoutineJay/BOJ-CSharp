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

            string s = sr.ReadLine();
            int a = int.Parse(s);

            for(int i=0; i<a; i++)
            {
                string[] s1 = sr.ReadLine().Split();
                int b = int.Parse(s1[0]);
                int c = int.Parse(s1[1]);

                int count = 0;

                while(true)
                {
                    if (b >= c)
                        break;

                    b = b * 2;
                    count++;
                }

                sb.AppendLine(count.ToString());
            }

            sw.Write(sb);

        }
    }
}