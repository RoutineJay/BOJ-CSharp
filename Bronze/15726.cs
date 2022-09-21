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
            string[] s = Console.ReadLine().Split(' ');

            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            double result1 = Math.Truncate(a * b / c);
            double result2 = Math.Truncate(a / b * c);

            if (result1 >= result2)
                Console.WriteLine(result1);
            else
                Console.WriteLine(result2);
            
        }
    }
}
