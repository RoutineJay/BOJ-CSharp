using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int c, d, f;
            string[] str = Console.ReadLine().Split();
            a = str[0];
            b = str[1];
            c = int.Parse(a);
            d = int.Parse(b);
            string str2 = Console.ReadLine();
            f = int.Parse(str2);

            d = d + f;

            if(d>59)
            {
                c++;
                d = d - 60;

                if (c == 24)
                {
                    c = 0;
                }

                if (d > 59)
                {
                    c++;
                    d = d - 60;

                    if (c == 24)
                    {
                        c = 0;
                    }

                    if (d > 59)
                    {
                        c++;
                        d = d - 60;

                        if (c == 24)
                        {
                            c = 0;
                        }

                        if (d > 59)
                        {
                            c++;
                            d = d - 60;

                            if (c == 24)
                            {
                                c = 0;
                            }

                            if (d > 59)
                            {
                                c++;
                                d = d - 60;

                                if (c == 24)
                                {
                                    c = 0;
                                }

                                if (d > 59)
                                {
                                    c++;
                                    d = d - 60;

                                    if (c == 24)
                                    {
                                        c = 0;
                                    }

                                    if (d > 59)
                                    {
                                        c++;
                                        d = d - 60;

                                        if (c == 24)
                                        {
                                            c = 0;
                                        }

                                        if (d > 59)
                                        {
                                            c++;
                                            d = d - 60;

                                            if (c == 24)
                                            {
                                                c = 0;
                                            }

                                            if (d > 59)
                                            {
                                                c++;
                                                d = d - 60;

                                                if (c == 24)
                                                {
                                                    c = 0;
                                                }

                                                if (d > 59)
                                                {
                                                    c++;
                                                    d = d - 60;

                                                    if (c == 24)
                                                    {
                                                        c = 0;
                                                    }

                                                    if (d > 59)
                                                    {
                                                        c++;
                                                        d = d - 60;

                                                        if (c == 24)
                                                        {
                                                            c = 0;
                                                        }

                                                        if (d > 59)
                                                        {
                                                            c++;
                                                            d = d - 60;

                                                            if (c == 24)
                                                            {
                                                                c = 0;
                                                            }

                                                            if (d > 59)
                                                            {
                                                                c++;
                                                                d = d - 60;

                                                                if (c == 24)
                                                                {
                                                                    c = 0;
                                                                }

                                                                if (d > 59)
                                                                {
                                                                    c++;
                                                                    d = d - 60;

                                                                    if (c == 24)
                                                                    {
                                                                        c = 0;
                                                                    }

                                                                    if (d > 59)
                                                                    {
                                                                        c++;
                                                                        d = d - 60;

                                                                        if (c == 24)
                                                                        {
                                                                            c = 0;
                                                                        }

                                                                        if (d > 59)
                                                                        {
                                                                            c++;
                                                                            d = d - 60;

                                                                            if (c == 24)
                                                                            {
                                                                                c = 0;
                                                                            }

                                                                            if (d > 59)
                                                                            {
                                                                                c++;
                                                                                d = d - 60;

                                                                                if (c == 24)
                                                                                {
                                                                                    c = 0;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
         
            Console.WriteLine($"{c} {d}");
        }
    }
}