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

            string[,] arr = new string[3, 3];
            string s = sr.ReadLine();
            int a = int.Parse(s);
            string start = null;

            if (a == 1)
                start = "o";
            else if (a == 2)
                start = "x";

            int result = 0;
            bool check = false;

            for(int i=0; i<9; i++)
            {
                string[] s1 = sr.ReadLine().Split();
                int x = int.Parse(s1[0]);
                int y = int.Parse(s1[1]);

                arr[x - 1, y - 1] = start;

                if (start == "o")
                    start = "x";
                else if (start == "x")
                    start = "o";

                if(arr[0,0] == "o" && arr[0, 1] == "o" && arr[0, 2] == "o" && check == false)
                {
                    result = 1;
                    check = true;
                }
                else if (arr[1, 0] == "o" && arr[1, 1] == "o" && arr[1, 2] == "o" && check == false)
                {
                    result = 1;
                    check = true;
                }
                else if (arr[2, 0] == "o" && arr[2, 1] == "o" && arr[2, 2] == "o" && check == false)
                {
                    result = 1;
                    check = true;
                }

                else if (arr[0, 0] == "o" && arr[1, 0] == "o" && arr[2, 0] == "o" && check == false)
                {
                    result = 1;
                    check = true;
                }
                else if (arr[0, 1] == "o" && arr[1, 1] == "o" && arr[2, 1] == "o" && check == false)
                {
                    result = 1;
                    check = true;
                }
                else if (arr[0, 2] == "o" && arr[1, 2] == "o" && arr[2, 2] == "o" && check == false)
                {
                    result = 1;
                    check = true;
                }

                else if (arr[0, 0] == "o" && arr[1, 1] == "o" && arr[2, 2] == "o" && check == false)
                {
                    result = 1;
                    check = true;
                }
                else if (arr[0, 2] == "o" && arr[1, 1] == "o" && arr[2, 0] == "o" && check == false)
                {
                    result = 1;
                    check = true;
                }

                else if (arr[0, 0] == "x" && arr[0, 1] == "x" && arr[0, 2] == "x" && check == false)
                {
                    result = 2;
                    check = true;
                }
                else if (arr[1, 0] == "x" && arr[1, 1] == "x" && arr[1, 2] == "x" && check == false)
                {
                    result = 2;
                    check = true;
                }
                else if (arr[2, 0] == "x" && arr[2, 1] == "x" && arr[2, 2] == "x" && check == false)
                {
                    result = 2;
                    check = true;
                }

                else if (arr[0, 0] == "x" && arr[1, 0] == "x" && arr[2, 0] == "x" && check == false)
                {
                    result = 2;
                    check = true;
                }
                else if (arr[0, 1] == "x" && arr[1, 1] == "x" && arr[2, 1] == "x" && check == false)
                {
                    result = 2;
                    check = true;
                }
                else if (arr[0, 2] == "x" && arr[1, 2] == "x" && arr[2, 2] == "x" && check == false)
                {
                    result = 2;
                    check = true;
                }

                else if (arr[0, 0] == "x" && arr[1, 1] == "x" && arr[2, 2] == "x" && check == false)
                {
                    result = 2;
                    check = true;
                }
                else if (arr[0, 2] == "x" && arr[1, 1] == "x" && arr[2, 0] == "x" && check == false)
                {
                    result = 2;
                    check = true;
                }
            }

            sw.WriteLine(result);
        }
    }
}