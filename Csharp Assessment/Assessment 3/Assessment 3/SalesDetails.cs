using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class SalesDetails
    {
        private int TransactionID;
        private int ProductID;
        private double UnitPrice;
        private DateTime TransactionDate;
        private int QuantitySold;
        private double TotalAmount;

        public SalesDetails(int transactionID, int productID, double unitPrice, int quantitySold, DateTime transactionDate)
        {
            TransactionID = transactionID;
            ProductID = productID;
            UnitPrice = unitPrice;
            QuantitySold = quantitySold;
            TransactionDate = transactionDate;
        }

        public void CalculateAmount()
        {
            TotalAmount = QuantitySold * UnitPrice;
        }

        public void DisplayTransactionDetails()
        {
            Console.WriteLine("Sales Transaction Details:");
            Console.WriteLine($"Transaction ID: {TransactionID}");
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Unit Price: {UnitPrice}");
            Console.WriteLine($"Quantity Sold: {QuantitySold}");
            Console.WriteLine($"Total Amount: {TotalAmount}");
            Console.WriteLine($"Transaction Date: {TransactionDate}");
        }

        static void Main()
        {
            SalesDetails sd = new SalesDetails(1001, 32, 399, 2, DateTime.Now);
            sd.CalculateAmount();
            sd.DisplayTransactionDetails();
            Console.Read();
        }

    }
}
