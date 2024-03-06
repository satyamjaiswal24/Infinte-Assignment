using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2

{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int account_no =0;
            string cust_name = "", account_type = "";
            Accountant acc = null;




            while (flag)
            {
                if(account_no == 0)
                {
                    Console.WriteLine("--------------Create Your Account---------------\n");
                    Console.Write("Create your account_no.: ");
                    account_no = int.Parse(Console.ReadLine());
                    Console.Write("Enter Your Name: ");
                    cust_name = Console.ReadLine();
                    Console.Write("Create Your Account Type: ");
                    account_type = Console.ReadLine();
                    acc = new Accountant(account_no, cust_name, account_type);

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
                            Console.Write("Enter Transaction Type:---\nDeposit for 'd' or 'D'\n" +
                                "Withdrawal 'w' or 'W': ");
                            char type = Convert.ToChar(Console.ReadLine());
                            Console.Write("Enter Amount: ");
                            int amount = int.Parse(Console.ReadLine());
                            acc.transaction_type(type, amount);

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
    }
}
