using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4
{
    class Array_Solution
    {

        static void Main()
        {
            minMax_and_Average();
            displayMarks();
            copyArray();
            Console.Read();
        }


        static void minMax_and_Average()
        {
            Console.Write("Enter the size of the array: ");
            int len = int.Parse(Console.ReadLine());

            int[] arr = new int[len];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < len; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int avg = 0;
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < len; ++i)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
                avg += arr[i];
            }

            avg = avg / len;
            Console.WriteLine($"Average value: {avg}");
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");


        }
        static void displayMarks()
        {

            int[] marks = new int[10];
            int len = marks.Length;

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < len; ++i)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            int avg, total = 0;
            int min = marks[0];
            int max = marks[0];
            for (int i = 0; i < len; ++i)
            {
                if (max < marks[i])
                {
                    max = marks[i];
                }
                if (min > marks[i])
                {
                    min = marks[i];
                }
                total += marks[i];
            }

            avg = total / len;
            Console.WriteLine($"Total value: {total}");
            Console.WriteLine($"Average value: {avg}");
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine("Marks in Ascending Order:");
            for (int i = 0; i < len; ++i)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("Marks in Descending Order:");
            for (int i = len - 1; i >= 0; --i)
            {
                Console.WriteLine(marks[i]);
            }
        }
        static void copyArray()
        {
            Console.Write("Enter the size of the array: ");
            int len = int.Parse(Console.ReadLine());

            int[] a = new int[len];

            Console.WriteLine("Enter the elements of the array A:");
            for (int i = 0; i < len; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int[] b = new int[len];

            for (int i = 0; i < len; ++i)
            {
                b[i] = a[i];
            }

            Console.WriteLine("elements in the array B:");
            for (int i = 0; i < len; ++i)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
