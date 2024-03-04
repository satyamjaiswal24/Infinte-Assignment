using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Accountant
    {
        int account_no;
        string cust_name, account_type;
        private float balance =0;

        public Accountant(int account_no, string cust_name,string account_type)
        {
            this.account_no = account_no;
            this.cust_name = cust_name;
            this.account_type = account_type;
        }

        public float Balance
        {
            get { return balance; }
            set{ balance = value; }
        }


        public void transaction_type(char type, int amount)
        {
            if(amount < 0 && ((type.Equals('w')) || (type.Equals('W'))))
            {
                Console.WriteLine("Your balance is 0, so you can not withdrawal money");
            }
            else if(type.Equals('d') || type.Equals('D'))
            {
                Balance += amount;
                Console.WriteLine("amount deposit successfully");
            }
            else if(type.Equals('w') || type.Equals('W'))
            {
                Balance -= amount;
                Console.WriteLine("amount withdrawal successfully");

            }
            else
            {
                Console.WriteLine("Please Enter valid Transaction Type\n\n");
            }
        }

        public void show_information()
        {
            Console.WriteLine("Customer Account No. ; "+account_no);
            Console.WriteLine("Customer Name: "+cust_name);
            Console.WriteLine($"Customer Account Balance: {balance} rs");
            Console.WriteLine($"Customer Account type: {account_type}");

        }


    }
}
