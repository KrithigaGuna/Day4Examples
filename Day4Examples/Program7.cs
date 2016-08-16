using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Examples
{
    class Program7
    {
        public static void Main()
        {
            string s = "Institute of System Science";

            string[] multipleString = s.Split();

            for (int i = 0; i < multipleString.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, multipleString[i]);
            }

            Console.WriteLine(multipleString[1]);

            //string input = Console.ReadLine();
            //string[] splitInput = input.Split();

            //double x1 = Convert.ToDouble(splitInput[0]);
            //double y1 = Convert.ToDouble(splitInput[1]);
            //double x2 = Convert.ToDouble(splitInput[2]);
            //double y2 = Convert.ToDouble(splitInput[3]);

            //double distance = Math.Sqrt( Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

            //Console.WriteLine("Distance: {0}", distance);

            string csv = "Name,,,,,Phone,NRIC";
           
            string[] values = csv.Split(',');

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            string s1 = "John Smith";

            Console.WriteLine("The seventh character is {0}",s1.Substring(6,1));
            Console.WriteLine("The seventh character is {0}", s1[6]);

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != 'S')
                    Console.Write(Char.ToLower(s1[i]));
            }

        }
    }
}
