using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Examples
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int hcf = 0;
            int lcm = 0;

            CalculateHCFAndLCM(a, b, ref hcf, ref lcm);

            Console.WriteLine("HCF:" + hcf);
            Console.WriteLine("LCM:" + lcm);
        }

        public static void CalculateHCFAndLCM(int a, int b, ref int hcf, ref int lcm)
        {
            //YOUR CODE HERE
            //Don't worry about the use of "ref" keyword here. 
            //At the end of the method, assign the HCF value to the hcf parameter
            //and LCM to the lcm parameter. hcf = <some value>; lcm=<some value>;

            int larger = Math.Max(a,b);
            int smaller = Math.Min(a,b);

            //if (a > b)
            //{
            //    larger = a;
            //    smaller = b;
            //}
            //else
            //{
            //    larger = b;
            //    smaller = a;
            //}

            while (larger != smaller)
            {
                larger = larger - smaller;
                if (larger < smaller)
                {
                    int tmp = larger;
                    larger = smaller;
                    smaller = tmp;
                }
            } //exit when larger == smaller

            hcf = larger;
            lcm = (a * b) / hcf;
        }
    }
}
