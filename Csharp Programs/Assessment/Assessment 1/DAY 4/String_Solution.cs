using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class String_Solution
    {
        static void Main()
        {
            length_of_string();
            reverse_of_string();
            compare_of_string();
            Console.ReadKey();
        }
        static void length_of_string()
        {
            Console.Write("Enter the string: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Length of String is: {s.Length}");
        }
        static void reverse_of_string()
        {
            Console.Write("Enter the string: ");
            String s = Console.ReadLine();
            String st = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                st += s[i];
            }
            Console.WriteLine($"Reverse String is: {st}");
        }
        static void compare_of_string()
        {
            Console.Write("Enter 1st the string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter 2nd the string: ");
            string s2 = Console.ReadLine();

            if (s1.Equals(s2))
            {
                Console.WriteLine("String 1 and String 2 are equals");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
