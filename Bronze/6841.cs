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

            Hashtable ht = new Hashtable();
            ht.Add("CU", "see you");
            ht.Add(":-)", "I’m happy");
            ht.Add(":-(", "I’m unhappy");
            ht.Add(";-)", "wink");
            ht.Add(":-P", "stick out my tongue");
            ht.Add("(~.~)", "sleepy");
            ht.Add("TA", "totally awesome");
            ht.Add("CCC", "Canadian Computing Competition");
            ht.Add("CUZ", "because");
            ht.Add("TY", "thank-you");
            ht.Add("YW", "you’re welcome");
            ht.Add("TTYL", "talk to you later");

            while (true)
            {
                string s = Console.ReadLine();

                if(ht[s] == null)
                    Console.WriteLine(s);
                else
                    Console.WriteLine(ht[s]);

                if (s == "TTYL")
                    break;
            }
        }
    }
}