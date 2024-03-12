using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;

namespace Assignment_4
{
    class LamdaQueries
    {
        static void Main()
        {
            Console.WriteLine("-------------------- Ticket Concession App ------------------------");
            ticketConcessionApp();
            Console.WriteLine("-------------------- Return Word ------------------------");
            returnWord();
            Console.WriteLine("-------------------- Square Function ------------------------");
            square();
            Console.ReadKey();
        }
        static void returnWord()
        {
            Console.Write("Enter the size of an array: ");
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            Console.Write("Enter the elements in arr: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.Write("Result list: ");
            var res = arr.Where(s => s.StartsWith("a") && s.EndsWith("m"));
            foreach(var val in res)
            {
                Console.Write(val + " ");
            }
        }
        static void square()
        {
            List<int> list = new List<int>();
            Console.Write("Enter the size of list to add elements: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i} element: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            List<int> nlist = new List<int>();
            nlist.AddRange(list.Select(x => x * x).Where(sq => sq > 20));

            foreach (var res in nlist)
            {
                Console.Write(res + " ");
            }

        }
        static void ticketConcessionApp()
        {
            Console.Write("Enter the Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the Your Age: ");
            int age = int.Parse(Console.ReadLine());

            TicketConcession tc = new TicketConcession(age, name);
            tc.CalculateConcession();
            Console.ReadKey();
        }
    }
}
