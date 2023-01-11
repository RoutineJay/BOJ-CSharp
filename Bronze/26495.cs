using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; // Biginteger
using System.Collections;
using System.Runtime;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string s = Console.ReadLine();

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '0')
                {
                    sb.AppendLine("0000");
                    sb.AppendLine("0  0");
                    sb.AppendLine("0  0");
                    sb.AppendLine("0  0");
                    sb.AppendLine("0000");
                }
                else if (s[i] == '1')
                {
                    sb.AppendLine("   1");
                    sb.AppendLine("   1");
                    sb.AppendLine("   1");
                    sb.AppendLine("   1");
                    sb.AppendLine("   1");
                }
                else if (s[i] == '2')
                {
                    sb.AppendLine("2222");
                    sb.AppendLine("   2");
                    sb.AppendLine("2222");
                    sb.AppendLine("2");
                    sb.AppendLine("2222");
                }
                else if (s[i] == '3')
                {
                    sb.AppendLine("3333");
                    sb.AppendLine("   3");
                    sb.AppendLine("3333");
                    sb.AppendLine("   3");
                    sb.AppendLine("3333");
                }
                else if (s[i] == '4')
                {
                    sb.AppendLine("4  4");
                    sb.AppendLine("4  4");
                    sb.AppendLine("4444");
                    sb.AppendLine("   4");
                    sb.AppendLine("   4");
                }
                else if (s[i] == '5')
                {
                    sb.AppendLine("5555");
                    sb.AppendLine("5");
                    sb.AppendLine("5555");
                    sb.AppendLine("   5");
                    sb.AppendLine("5555");
                }
                else if (s[i] == '6')
                {
                    sb.AppendLine("6666");
                    sb.AppendLine("6");
                    sb.AppendLine("6666");
                    sb.AppendLine("6  6");
                    sb.AppendLine("6666");
                }
                else if (s[i] == '7')
                {
                    sb.AppendLine("7777");
                    sb.AppendLine("   7");
                    sb.AppendLine("   7");
                    sb.AppendLine("   7");
                    sb.AppendLine("   7");
                }
                else if (s[i] == '8')
                {
                    sb.AppendLine("8888");
                    sb.AppendLine("8  8");
                    sb.AppendLine("8888");
                    sb.AppendLine("8  8");
                    sb.AppendLine("8888");
                }
                else if (s[i] == '9')
                {
                    sb.AppendLine("9999");
                    sb.AppendLine("9  9");
                    sb.AppendLine("9999");
                    sb.AppendLine("   9");
                    sb.AppendLine("   9");
                }

                sb.AppendLine();

            }

            Console.Write(sb);

        }
    }
}