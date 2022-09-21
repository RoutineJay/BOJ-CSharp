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

            string[] s = sr.ReadLine().Split(' ');
            int count = s.Length;

            for(int i=0; i<s.Length; i++)
            {
                if (string.IsNullOrEmpty(s[i]) == true)
                    count--;
            }

            sw.WriteLine(count);




        }
    }
}
