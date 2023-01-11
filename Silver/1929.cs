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

            string[] s1 = sr.ReadLine().Split();
            int a = int.Parse(s1[0]);
            int b = int.Parse(s1[1]);

            int[] arr = new int[b-1];
            for(int i=0; i<=b-2; i++)
            {
                arr[i] = i + 2;
            }
            int count = arr[0];
            int zero = 0;
            int cnt = 0;

            while(true)
            {
                for(int i=0; i<arr.Length; i++)
                {
                    if (arr[i] % count == 0 && arr[i] != count)
                    {
                        arr[i] = 0;
                        zero++;
                    }
                }

                if (zero == 0)
                    break;

                Array.Sort(arr);
                Array.Reverse(arr);
                Array.Resize(ref arr, arr.Length - zero);
                Array.Sort(arr);

                zero = 0;
                cnt++;
                count = arr[cnt];

            }

            int sum = 0;
            int min = 0;

            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] >= a && arr[i] <= b)
                {
                    if (min == 0)
                        min = arr[i];

                    sum = sum + arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= a)
                    sb.AppendLine(arr[i].ToString());
            }

            sw.Write(sb);

        }
    }
}