using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{

    // Define the IStudent interface
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    // Implement the Dayscholar class
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar Details:\nStudent ID: {StudentId}\nName: {Name}");
        }
    }

    // Implement the Resident class
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Resident Details:\nStudent ID: {StudentId}\nName: {Name}");
        }
    }


    class Student
    {
        static void Main()
        {
            // Example usage
            Console.Write("Enter Day Scholar Student ID: ");
            int stdId = int.Parse(Console.ReadLine());
            Console.Write("Enter Day Scholar Student Name: ");
            string name = Console.ReadLine();
            IStudent dayscholar = new Dayscholar { StudentId = stdId, Name = name };
            Console.Write("Enter Resident Student ID: ");
            int stdIdRes = int.Parse(Console.ReadLine());
            Console.Write("Enter Resident Student Name: ");
            string nameRes= Console.ReadLine();
            IStudent resident = new Resident { StudentId = stdIdRes, Name = nameRes };

            dayscholar.ShowDetails();
            resident.ShowDetails();
        }
    }
}
