using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class RemoveChar
    {
        static void Main()
        {
            remove_char();
            Console.ReadKey();
        }
        public static void remove_char()
        {
            Console.Write("Enter the String: ");
            string s = Console.ReadLine();
            Console.Write("Enter the position you want to remove: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0 && n > s.Length)
            {
                Console.WriteLine("Please Enter Valid Position");
            }
            else
            {
                s = s.Remove(n, 1);
                Console.WriteLine(s);
            }
        }
    }
}
