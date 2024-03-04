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
            equal();
            positiveOrNot();
            operations();
            table();
            tripleProgram();
            dayName();
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
        
        
    }
}
