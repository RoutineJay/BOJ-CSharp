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

            while (true)
            {
                string s1 = sr.ReadLine();

                if (string.IsNullOrEmpty(s1) == true)
                    break;
                else
                {
                    string[] s = s1.Split(' ');

                    int a = int.Parse(s[0]);
                    int b = int.Parse(s[1]);
                    int c = int.Parse(s[2]);
                    int cb = c - b - 1;
                    int ba = b - a - 1;
                    int[] arr = new int[2];

                    arr[0] = cb;
                    arr[1] = ba;

                    Array.Sort(arr);

                    sw.WriteLine(arr[1]);
                }


            }
        }
    }
}
