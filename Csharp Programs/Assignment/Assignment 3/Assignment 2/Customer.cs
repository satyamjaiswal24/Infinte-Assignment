using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Customer
    {
        static int customer_id, age;
        static long phone;
        static string name, city;

        public Customer()
        {
        }

        public Customer(int cust_id, int cust_age, long cust_phone, string cust_name, string cust_city)
        {
            customer_id = cust_id;
            age = cust_age;
            phone = cust_phone;
            name = cust_name;
            city = cust_city;
        }

        public static void ShowData()
        {
            Console.WriteLine($"Customer Id: {customer_id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Phone No.: {phone}");
            Console.WriteLine($"City: {city}");



        }
        ~Customer()       // Destructor
        {
            Console.WriteLine("Object  Destroyed!");
            Console.Read();
        }
        static void Main()
        {
            Customer cust = new Customer(1,22,9876,"Satyam", "Hyd");

            ShowData();
            cust = null;
            GC.Collect();
            Console.Read();
        }


    }
    
    
}
