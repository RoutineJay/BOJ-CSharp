using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(a.Substring(0, 1));
            double c = double.Parse(a.Substring(2));

            Console.WriteLine(b / c);


        }
    }
}