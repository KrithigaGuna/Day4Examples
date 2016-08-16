using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Examples
{
    class Program3
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            for (int j = 9; j >= 0; j--)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("---------------");
            for (int k = 1; k <= 10; k = k+2)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("---------------");
            for (int l = 1; l <= 10; l++)
            {
                if (l % 2 == 0)
                    Console.WriteLine(l);
            }
        }
    }
}
