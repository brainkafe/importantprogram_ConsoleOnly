using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrome_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i want to make changes.
            string s, revs = "";
            Console.WriteLine("Enter a string value.");
            s = Console.ReadLine();

            for(int i=s.Length-1; i>=0; i--)
            {
                revs += s[i].ToString();
            }

            if (revs == s)      // checking whether string is palindrone or not
            {
                Console.WriteLine(s + " is Palindrome. \n Reverse the string is " + revs);
            }
            else
            {
                Console.WriteLine(s + " is not a Palindrome. \n Reverse of string is " + revs);
            }
            Console.ReadLine();
        }
    }
}
