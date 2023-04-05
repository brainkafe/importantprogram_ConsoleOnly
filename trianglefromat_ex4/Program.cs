using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglefromat_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val;
            Console.WriteLine("Enter the range to display triangle format");
            val = int.Parse(Console.ReadLine());
            for(int i = 1; i <= val; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    //Console.Write(j);
                    Console.Write("*"); //try this also.
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
