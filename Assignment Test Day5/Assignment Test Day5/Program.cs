using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Test_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Largest number among three program---------");
            LargestNumber.largest_num();
            Console.WriteLine("---------Remove Char program---------");
            RemoveChar.remove_char();
            Console.WriteLine("---------Replace Char program---------");
            replace_char();
            Console.ReadKey();
        }
        static void replace_char()
        {
            Console.Write("Enter the input: ");
            string s = Console.ReadLine();

            char[] arr = s.ToCharArray();

            char c = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = c;

            String st = new String(arr);
            Console.WriteLine($"Output: {st}");
        }
       
    }
}
