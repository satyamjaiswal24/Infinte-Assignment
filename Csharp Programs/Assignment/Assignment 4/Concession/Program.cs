using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the Your Age: ");
            int age = int.Parse(Console.ReadLine());

            TicketConcession tc = new TicketConcession();
            tc.name = name;
            tc.age = age;
            tc.CalculateConcession();
            Console.ReadKey();
        }
    }
}
