using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Examples
{
    class Program2
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SQT(n));
        }

        public static double SQT(int n)
        {
            Random r = new Random();
            double G = r.Next(1, n);

            do
            {
                G = (G + n / G) / 2;
            } while (Math.Abs(G * G - n) >= 0.00001);
            //} while (((G * G) - n >= 0.00001) || (n - (G * G) >= 0.00001));
            //exit condition:  N-0.00001 < G*G < N + 0.00001

            return G;
        }
    }
}
