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

            int acount = 0;
            int bcount = 0;
            int ccount = 0;
            int dcount = 0;
            int ecount = 0;
            int fcount = 0;
            int gcount = 0;
            int hcount = 0;
            int icount = 0;
            int jcount = 0;
            int kcount = 0;
            int lcount = 0;
            int mcount = 0;
            int ncount = 0;
            int ocount = 0;
            int pcount = 0;
            int qcount = 0;
            int rcount = 0;
            int scount = 0;
            int tcount = 0;
            int ucount = 0;
            int vcount = 0;
            int wcount = 0;
            int xcount = 0;
            int ycount = 0;
            int zcount = 0;

            string s = sr.ReadLine();
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'A')
                    acount++;
                else if (c[i] == 'b' || c[i] == 'B')
                    bcount++;
                else if (c[i] == 'c' || c[i] == 'C')
                    ccount++;
                else if (c[i] == 'd' || c[i] == 'D')
                    dcount++;
                else if (c[i] == 'e' || c[i] == 'E')
                    ecount++;
                else if (c[i] == 'f' || c[i] == 'F')
                    fcount++;
                else if (c[i] == 'g' || c[i] == 'G')
                    gcount++;
                else if (c[i] == 'h' || c[i] == 'H')
                    hcount++;
                else if (c[i] == 'i' || c[i] == 'I')
                    icount++;
                else if (c[i] == 'j' || c[i] == 'J')
                    jcount++;
                else if (c[i] == 'k' || c[i] == 'K')
                    kcount++;
                else if (c[i] == 'l' || c[i] == 'L')
                    lcount++;
                else if (c[i] == 'm' || c[i] == 'M')
                    mcount++;
                else if (c[i] == 'n' || c[i] == 'N')
                    ncount++;
                else if (c[i] == 'o' || c[i] == 'O')
                    ocount++;
                else if (c[i] == 'p' || c[i] == 'P')
                    pcount++;
                else if (c[i] == 'q' || c[i] == 'Q')
                    qcount++;
                else if (c[i] == 'r' || c[i] == 'R')
                    rcount++;
                else if (c[i] == 's' || c[i] == 'S')
                    scount++;
                else if (c[i] == 't' || c[i] == 'T')
                    tcount++;
                else if (c[i] == 'u' || c[i] == 'U')
                    ucount++;
                else if (c[i] == 'v' || c[i] == 'V')
                    vcount++;
                else if (c[i] == 'w' || c[i] == 'W')
                    wcount++;
                else if (c[i] == 'x' || c[i] == 'X')
                    xcount++;
                else if (c[i] == 'y' || c[i] == 'Y')
                    ycount++;
                else if (c[i] == 'z' || c[i] == 'Z')
                    zcount++;
            }

            int[] arr = new int[26] { acount, bcount, ccount, dcount, ecount, fcount, gcount,
                hcount, icount, jcount, kcount, lcount, mcount, ncount,
                ocount, pcount, qcount, rcount, scount, tcount, ucount,
                vcount, wcount, xcount, ycount, zcount };

            Array.Sort(arr);
            Array.Reverse(arr);

            string s1 = null;

            int temp = 0;
            for (int i = 0; i < 26; i++)
            {
                if (temp <= arr[i])
                {
                    temp = arr[i];

                    if (arr[i] == acount)
                        s1 = s1 + "A";
                    else if (arr[i] == bcount)
                        s1 = s1 + "B";
                    else if (arr[i] == ccount)
                        s1 = s1 + "C";
                    else if (arr[i] == dcount)
                        s1 = s1 + "D";
                    else if (arr[i] == ecount)
                        s1 = s1 + "E";
                    else if (arr[i] == fcount)
                        s1 = s1 + "F";
                    else if (arr[i] == gcount)
                        s1 = s1 + "G";
                    else if (arr[i] == hcount)
                        s1 = s1 + "H";
                    else if (arr[i] == icount)
                        s1 = s1 + "I";
                    else if (arr[i] == jcount)
                        s1 = s1 + "J";
                    else if (arr[i] == kcount)
                        s1 = s1 + "K";
                    else if (arr[i] == lcount)
                        s1 = s1 + "L";
                    else if (arr[i] == mcount)
                        s1 = s1 + "M";
                    else if (arr[i] == ncount)
                        s1 = s1 + "N";
                    else if (arr[i] == ocount)
                        s1 = s1 + "O";
                    else if (arr[i] == pcount)
                        s1 = s1 + "P";
                    else if (arr[i] == qcount)
                        s1 = s1 + "Q";
                    else if (arr[i] == rcount)
                        s1 = s1 + "R";
                    else if (arr[i] == scount)
                        s1 = s1 + "S";
                    else if (arr[i] == tcount)
                        s1 = s1 + "T";
                    else if (arr[i] == ucount)
                        s1 = s1 + "U";
                    else if (arr[i] == vcount)
                        s1 = s1 + "V";
                    else if (arr[i] == wcount)
                        s1 = s1 + "W";
                    else if (arr[i] == xcount)
                        s1 = s1 + "X";
                    else if (arr[i] == ycount)
                        s1 = s1 + "Y";
                    else if (arr[i] == zcount)
                        s1 = s1 + "Z";
                }
                else
                    break;
            }

            if (s1.Length > 1)
                sw.WriteLine("?");
            else
                sw.WriteLine(s1);


        }
    }
}