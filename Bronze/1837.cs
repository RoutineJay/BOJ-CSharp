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

            string[] s = sr.ReadLine().Split();
            BigInteger p = BigInteger.Parse(s[0]);
            BigInteger q = int.Parse(s[1]);

            BigInteger[] arr = new BigInteger[(int)q - 1];

            for (int i = 2; i < q; i++)
            {
                arr[i - 2] = i;
            }
            BigInteger count = arr[0];
            int zero = 0;
            int cnt = 0;

            while (true)
            {
                if (arr.Length == 1)
                {
                    arr[0] = 2;
                    break;
                }

                for (int i = 0; i < arr.Length; i++)
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
                Array.Reverse(arr);

                if (arr.Length > 1)
                    cnt++;
                count = arr[cnt];
                zero = 0;
            }

            bool swi = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (p % arr[i] == 0 && arr[i] < q)
                {
                    sw.WriteLine($"BAD {arr[i]}");
                    swi = true;
                    break;
                }
            }

            if (swi == false)
                sw.WriteLine("GOOD");




        }
    }
}