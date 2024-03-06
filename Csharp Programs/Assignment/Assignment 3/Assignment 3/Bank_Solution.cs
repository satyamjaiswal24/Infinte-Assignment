using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Bank_Solution
    {
        static void Main()
        {
            bool flag = true;
            int account_no = 0;
            string cust_name = "", account_type = "";
            Bank_Solution acc = null;




            while (flag)
            {
                if (account_no == 0)
                {
                    Console.WriteLine("--------------Create Your Account---------------\n");
                    Console.Write("Create your account_no.: ");
                    account_no = int.Parse(Console.ReadLine());
                    Console.Write("Enter Your Name: ");
                    cust_name = Console.ReadLine();
                    Console.Write("Create Your Account Type: ");
                    account_type = Console.ReadLine();
                    acc = new Bank_Solution(account_no, cust_name, account_type);

                }
                else
                {
                    Console.WriteLine("\n\n----------------------------------------");
                    Console.WriteLine("1.Transaction\n2.Show Information\n3.Exit");
                    Console.Write("Select an option: ");
                    int n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            
                            Console.WriteLine("\n\na. Deposit\nb. Withdrawal");
                            Console.Write("Select an option: ");
                            char c = Convert.ToChar(Console.ReadLine());
                            int amount = int.Parse(Console.ReadLine());


                            switch (c)
                            {
                                case 'a':
                                    acc.deposit(amount);
                                    break; 
                                case 'b':
                                    Console.Write("Enter Amount: ");
                                    acc.withdrawl(amount);
                                    break;

                                default:
                                    Console.WriteLine("Enter valid Character");
                                    break;
                            }
                            

                            break;
                        case 2:
                            acc.show_information();
                            break;
                        case 3:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Please Select Valid Number");
                            break;
                    }
                }

            }
            Console.ReadKey();
        }
        int account_no;
        string cust_name, account_type;
        private float balance = 0;

        public Bank_Solution(int account_no, string cust_name, string account_type)
        {
            this.account_no = account_no;
            this.cust_name = cust_name;
            this.account_type = account_type;
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        
        public void deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("amount deposit successfully");
        }

        public void withdrawl(int amount)
        {
            if (amount <= 0 )
            {
                throw new InsufficentAmountException("Insufficient balance for withdrawal.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("amount withdrawal successfully");

            }
        }

        public void show_information()
        {
            Console.WriteLine("Customer Account No. ; " + account_no);
            Console.WriteLine("Customer Name: " + cust_name);
            Console.WriteLine($"Customer Account Balance: {balance} rs");
            Console.WriteLine($"Customer Account type: {account_type}");

        }
    }

    class InsufficentAmountException: Exception
    {
        public InsufficentAmountException(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
