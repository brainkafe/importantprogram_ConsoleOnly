using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversestring_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine("Enter string.");
            s = Console.ReadLine();
            for(int i=s.Length-1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            Console.WriteLine("Reverse of " + s + " is " + revs);
            Console.ReadLine();
        }
    }
}
