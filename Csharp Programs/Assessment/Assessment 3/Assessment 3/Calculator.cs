using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class Calculator
    {
        delegate int Calculator_Delegate(int num1, int num2);
        static void Main()
        {
            bool flag = true;
            Calculator_Delegate cal;

            while (flag)
            {
                Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Exit\n");
                Console.Write("Select an option: ");
                int opt = int.Parse(Console.ReadLine());
                int num1, num2, result;

                switch (opt)
                {
                    case 1:
                        cal = new Calculator_Delegate(addition);
                        Console.WriteLine("Enter first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        num2 = int.Parse(Console.ReadLine());
                        result = cal(num1, num2);
                        Console.WriteLine($"Result of addition: {result}");
                        break;
                    case 2:
                        cal = new Calculator_Delegate(subtraction);
                        Console.WriteLine("Enter first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        num2 = int.Parse(Console.ReadLine());
                        result = cal(num1, num2);
                        Console.WriteLine($"Result of addition: {result}");
                        break;
                    case 3:
                        cal = new Calculator_Delegate(multiplication);
                        Console.WriteLine("Enter first number: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number: ");
                        num2 = int.Parse(Console.ReadLine());
                        result = cal(num1, num2);
                        Console.WriteLine($"Result of addition: {result}");
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }

        static int addition(int num1 , int num2)
        {
            return num1 + num2;
        }

        static int subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        static int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
