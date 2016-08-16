using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Examples
{
    class Program5
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }

        public static bool isPrime(int n)
        {
            //prime number can be divided only by itself and 1
            //n % n = 0, n%1=0, n% anything else != 0
            //the plan is: loop through from 2 to (n-1) inclusive
            //              check remainder
            //              if remainder is 0, then definitely not a prime

            //             set isprime to true
            //             loop through from 2 to (n-1) inclusive
            //                  check remainder
            //                  if remainder is 0, then set isprime to false
            //             isprime indicates whether n is prime or not

            //since the procedure works only for n>=2, then for n<2 
            //  straighaway return false;

            if (n < 2)
            {
                return false;
            }

            bool isPrime = true;
            for (int i = 2; i <= n - 1; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
