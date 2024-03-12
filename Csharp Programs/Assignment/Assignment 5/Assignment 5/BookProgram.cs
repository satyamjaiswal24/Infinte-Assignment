
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authoName)
        {
            BookName = bookName;
            AuthorName = authoName;
        }
        public void display()
        {
            Console.WriteLine($"Book Name is:- {BookName} and Author Name is:- {AuthorName}");
        }
    }

    class BookShelf
    {
        private Books []b = new Books[5];

        public Books this[int index]
        {
            get 
            {
                /* return the specified index here */
                return b[index];
            }
            set 
            {
                /* set the specified index to value here */
                b[index] = value;
            }
        }
    }

    class BookProgram
    {
        static void Main(string[] args)
        {
            BookShelf bs = new BookShelf();

            for(int i =0; i<5; i++)
            {
                Console.Write($"Write {i+1} Book Name: ");
                string bname = Console.ReadLine();
                Console.Write($"Write {i+1} Author Name: ");
                string aname = Console.ReadLine();

                bs[i] = new Books(bname, aname);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Book {i + 1}:");
                bs[i]?.display(); // Use null conditional operator to handle null books
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
