using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Bank_Solution
    {
        public float balance;

        public Bank_Solution(int amount)
        {
            balance = amount;
        }

        
        public void deposit(int amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Write a valid amount ");
            }
            else
            {
                balance += amount;
                Console.WriteLine("amount deposit successfully");
            }
           
        }

        public void withdrawl(int amount)
        {
            if(amount > balance)
            {
                throw new InsufficentAmountException("Insufficient balance for withdrawal.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("amount withdrawal successfully");

            }
        }

    }

    class InsufficentAmountException: Exception
    {
        public InsufficentAmountException(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
    class Solution
    {
        public static void Main()
        {
            Bank_Solution bs = new Bank_Solution(300);
            bs.deposit(9000);
            bs.withdrawl(4000);
            Console.ReadKey();
        }
    }
}
