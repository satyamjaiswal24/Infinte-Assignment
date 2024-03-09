﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class ReturnWord
    {
        static void Main()
        {
            Console.Write("Enter the size of an array: ");
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            Console.Write("Enter the elements in arr: ");
            for(int i =0; i<n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.Write("Result list: ");
            returnWord(arr);
            Console.ReadKey();
        }
        static void returnWord(string[] arr)
        {
            var res = arr.Where(s => s.StartsWith("a") && s.EndsWith("m"));
            foreach(var val in res)
            {
                Console.Write(val + " ");
            }
        }
    }
}
