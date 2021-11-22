using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2Assignement5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter A Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int i, j;

            int[,] array = new int[n, n];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                    Console.Write(array[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
        }
    }
}
