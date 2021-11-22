using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2Assignement1
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int m;

                Console.WriteLine("Please Enter A Number");
                m = Convert.ToInt32(Console.ReadLine());

                int a, b, c;

                for (a = 0; a <= m; a++)
                {
                    for (b = 0; b <= a; b++)
                    {
                        for (c = 0; c <= b; c++)
                        {
                            if (a + b + c == 10)
                            {
                                Console.WriteLine("{0},{1},{2}", a, b, c);
                            }
                        }
                    }
                }




            }
        
    }
}
