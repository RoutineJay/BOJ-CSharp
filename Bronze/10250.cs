using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string s1 = Console.ReadLine();
            int a = int.Parse(s1);

            for(int k=0; k<a; k++)
            {
                string[] s = Console.ReadLine().Split();

                int h = int.Parse(s[0]);
                int w = int.Parse(s[1]);
                int n = int.Parse(s[2]);

                int[,] arr = new int[h, w];

                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        arr[i, j] = (101 + j) + (i * 100);
                    }
                }

                int h1 = 0;
                int w1 = 0;
                int room = 0;

                while (n > 0)
                {
                    room = arr[h1, w1];

                    h1++;
                    n--;

                    if (h1 - 1 == h - 1)
                    {
                        h1 = 0;
                        w1++;
                    }


                }

                sb.AppendLine(room.ToString());
            }

            Console.Write(sb);

        }
    }
}