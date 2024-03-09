using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    class TicketConcession
    {
        private const int totalFlare = 500;

        public int age { get; set; }
        public string name { get; set; }

        public void CalculateConcession()
        {
            if (age <= 5)
            {
                Console.WriteLine($"Name: {name} and Age: {age}");
                Console.WriteLine("Little Champs - Free Ticket ");
            }
            else if(age >=60)
            {
                float discount_money = (totalFlare * 30) / 100;
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
