using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2Assignement3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Size of array:");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[a];

            Console.WriteLine("Enter {0} elements in the array", a);
            for (int i = 0; i < a; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("All odd numbers in array are: ");
            for (int n = 0; n < a; n++)
            {
                if (array[n] % 2 != 0)
                {
                    Console.Write(array[n] + " ");
                }
            }

        }
    }
}
