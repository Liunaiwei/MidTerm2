using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2Assignement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter String");
            string line = Console.ReadLine();


            Console.WriteLine("Reversed String:  ");

            for (int i = line.Length - 1; i >= 0; i--)
            {
                Console.Write(line[i]);
            }



        }
    }
}
