using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Midterm2Assignement4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int");
            int n = Convert.ToInt32(Console.ReadLine());

            StreamWriter writer = new StreamWriter("test.txt");
            for (int i = 1; i <= n; i++)
            {
                writer.Write(i);
                writer.Write("\t");
            }
            writer.Close();
            Console.WriteLine("Successful!");
        }
    }
}
