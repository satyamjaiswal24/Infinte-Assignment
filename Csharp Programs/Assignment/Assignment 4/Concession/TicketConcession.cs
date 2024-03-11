using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        private const int totalFlare = 500;

        private int age;
        private string name;

        public TicketConcession(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void CalculateConcession()
        {
            if (age < 0)
            {
                Console.WriteLine("Please give valid age input");
            }
            else if (age <= 5)
            {
                Console.WriteLine($"Name: {name} and Age: {age}");
                Console.WriteLine("Little Champs - Free Ticket ");
            }
            else if (age >= 60)
            {
                float discount_money = totalFlare - ((totalFlare * 30) / 100);
                Console.WriteLine($"Name: {name} and Age: {age}");
                Console.WriteLine($"Senior Citizen, Price with discount: {discount_money}rs");
            }
            else
            {
                Console.WriteLine($"Name: {name} and Age: {age}");
                Console.WriteLine($"Ticket Booked, Price: {totalFlare}rs");
            }
        }
    }
}
