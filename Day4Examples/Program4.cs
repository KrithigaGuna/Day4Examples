using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Examples
{
    class Program4
    {
        public static void Main()
        {
            int counter = 0;
            bool isPINAccepted = false;

            do
            {
                Console.WriteLine("Welcome to the Bank of ISS");
                Console.Write("Enter your PIN: ");
                string enteredPIN = Console.ReadLine();
                counter++;

                if (enteredPIN == "123456")
                {
                    Console.WriteLine("PIN accepted.");
                    isPINAccepted = true;
                }
                else
                {
                    if (counter < 3)
                    {
                        Console.WriteLine("Incorrect PIN. Please try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
                    }
                }
            } while (!isPINAccepted && counter <3);
        }
    }
}
