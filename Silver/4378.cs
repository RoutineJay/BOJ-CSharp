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
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;

            while(true)
            {
                string s = sr.ReadLine();
                if (string.IsNullOrEmpty(s) == true)
                    break;

                char[] c = s.ToCharArray();
                string s1 = null;

                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == '1')
                        s1 = s1 + "`";
                    else if (c[i] == ' ')
                        s1 = s1 + " ";

                    else if (c[i] == 'W')
                        s1 = s1 + "Q";
                    else if (c[i] == 'S')
                        s1 = s1 + "A";
                    else if (c[i] == 'X')
                        s1 = s1 + "Z";
                    else if (c[i] == '2')
                        s1 = s1 + "1";

                    else if (c[i] == '3')
                        s1 = s1 + "2";
                    else if (c[i] == 'E')
                        s1 = s1 + "W";
                    else if (c[i] == 'D')
                        s1 = s1 + "S";
                    else if (c[i] == 'C')
                        s1 = s1 + "X";

                    else if (c[i] == '4')
                        s1 = s1 + "3";
                    else if (c[i] == 'R')
                        s1 = s1 + "E";
                    else if (c[i] == 'F')
                        s1 = s1 + "D";
                    else if (c[i] == 'V')
                        s1 = s1 + "C";

                    else if (c[i] == '5')
                        s1 = s1 + "4";
                    else if (c[i] == 'T')
                        s1 = s1 + "R";
                    else if (c[i] == 'G')
                        s1 = s1 + "F";
                    else if (c[i] == 'B')
                        s1 = s1 + "V";

                    else if (c[i] == '6')
                        s1 = s1 + "5";
                    else if (c[i] == 'Y')
                        s1 = s1 + "T";
                    else if (c[i] == 'H')
                        s1 = s1 + "G";
                    else if (c[i] == 'N')
                        s1 = s1 + "B";

                    else if (c[i] == '7')
                        s1 = s1 + "6";
                    else if (c[i] == 'U')
                        s1 = s1 + "Y";
                    else if (c[i] == 'J')
                        s1 = s1 + "H";
                    else if (c[i] == 'M')
                        s1 = s1 + "N";

                    else if (c[i] == '8')
                        s1 = s1 + "7";
                    else if (c[i] == 'I')
                        s1 = s1 + "U";
                    else if (c[i] == 'K')
                        s1 = s1 + "J";
                    else if (c[i] == ',')
                        s1 = s1 + "M";

                    else if (c[i] == '9')
                        s1 = s1 + "8";
                    else if (c[i] == 'O')
                        s1 = s1 + "I";
                    else if (c[i] == 'L')
                        s1 = s1 + "K";
                    else if (c[i] == '.')
                        s1 = s1 + ",";

                    else if (c[i] == '0')
                        s1 = s1 + "9";
                    else if (c[i] == 'P')
                        s1 = s1 + "O";
                    else if (c[i] == ';')
                        s1 = s1 + "L";
                    else if (c[i] == '/')
                        s1 = s1 + ".";

                    else if (c[i] == '-')
                        s1 = s1 + "0";
                    else if (c[i] == '[')
                        s1 = s1 + "P";
                    else if (c[i] == '\'')
                        s1 = s1 + ";";
                    else if (c[i] == '/')
                        s1 = s1 + ".";

                    else if (c[i] == '=')
                        s1 = s1 + "-";
                    else if (c[i] == ']')
                        s1 = s1 + "[";

                    else if (c[i] == '\\')
                        s1 = s1 + "]";

                    else
                        s1 = s1 + c[i].ToString();
                }

                sb.AppendLine(s1);
            }

            sw.Write(sb);
        }
    }
}