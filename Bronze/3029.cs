using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; // Biginteger
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string[] s1 = Console.ReadLine().Split(':');
            string[] s2 = Console.ReadLine().Split(':');

            int hh1 = int.Parse(s1[0]);
            int mm1 = int.Parse(s1[1]);
            int ss1 = int.Parse(s1[2]);

            int hh2 = int.Parse(s2[0]);
            int mm2 = int.Parse(s2[1]);
            int ss2 = int.Parse(s2[2]);

            int hh3 = 0;
            int mm3 = 0;
            int ss3 = 0;

            while(true)
            {
                ss1++;
                ss3++;

                if (ss1 >= 60)
                {
                    mm1++;
                    ss1 = ss1 - 60;
                }

                if (mm1 >= 60)
                {
                    hh1++;
                    mm1 = mm1 - 60;
                }

                if(hh1 >= 24)
                {
                    hh1 = hh1 - 24;
                }

                if (ss3 >= 60)
                {
                    mm3++;
                    ss3 = ss3 - 60;
                }

                if (mm3 >= 60)
                {
                    hh3++;
                    mm3 = mm3 - 60;
                }

                if (hh1 == hh2 && mm1 == mm2 && ss1 == ss2)
                    break;
            }

            string hh4 = hh3.ToString();
            string mm4 = mm3.ToString();
            string ss4 = ss3.ToString();

            if (hh4.Length == 1)
                hh4 = "0" + hh4;

            if (mm4.Length == 1)
                mm4 = "0" + mm4;

            if (ss4.Length == 1)
                ss4 = "0" + ss4;

            Console.WriteLine($"{hh4}:{mm4}:{ss4}");

        }
    }
}