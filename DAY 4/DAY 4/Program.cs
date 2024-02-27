using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //displayMarks();
            //reverse_of_string();
            compare_of_string();
            Console.ReadKey();
        }
        static void equal()
        {
            Console.Write("Input the 1st number: ");
            int a = Convert.ToInt32( Console.ReadLine());
            Console.Write("Input the 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} and {b} is equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }
        static void positiveOrNot()
        {
            Console.Write("Test Data: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a > 0)
            {
                Console.WriteLine($"{a} is a Positive Number");
            }
            else
            {
                Console.WriteLine($"{a} is a Negative Number");
            }
        }
        static void operations()
        {
            Console.Write("Input 1st Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.Write("Input 2nd Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} = {a+b}");
                    break;
                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case '/':
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine("Please enter -, +, *, / operations only");
                    break;

            }

            
        }
        static void table()
        {
            Console.Write("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine($"{a} * {i} = {a*i}");
            }
        }
        static void tripleProgram()
        {
            Console.Write("Input the 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            if (a == b)
            {
                Console.WriteLine($"The triple of the sum is: {3*sum}");
            }
            else
            {
                Console.WriteLine($"sum of number is {sum}");
            }
        }
        static void dayName()
        {
            Console.Write("Enter number b/w 1 to 7: ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please Enter number b/w 1 to 7 only");
                    break;
            }
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
                if(max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
                avg += arr[i];
            }
            
            avg = avg / 2;
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
            for (int i = len-1; i >= 0; --i)
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
            for(int i =s.Length-1; i>=0; i--)
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
