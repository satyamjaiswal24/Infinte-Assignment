using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Test_Day5
{
    class LargestNumber
    {
        public static void largest_num()
        {
            Console.Write("Enter three inputs: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"Largest number is: {a}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"Largest number is: {b}");
            }
            else
            {
                Console.WriteLine($"Largest number is: {c}");
            }
        }
    }
}
