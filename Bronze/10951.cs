using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string s = Console.ReadLine();
                if(s == null)
                {
                    break;
                }
                
                string[] str = s.Split();
                
                int b = int.Parse(str[0]);
                int c = int.Parse(str[1]);
            
                Console.WriteLine(b + c);
            }
            


        }
    }
}