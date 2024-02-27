using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Instance_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.swap(10, 20); //Instance Method
            even_or_odd(10);//Static Method
            Console.Read();
        }

        void swap(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a : {a} and b : {b}");
        }

        static void even_or_odd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }
    }
}
