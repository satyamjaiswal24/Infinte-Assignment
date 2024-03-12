using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    // Base class: Employee
    class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }

        public Employee(int empId, string empName, float salary)
        {
            Empid = empId;
            Empname = empName;
            Salary = salary;
        }
    }

    // Derived class: ParttimeEmployee
    class ParttimeEmployee : Employee
    {
        public float Wages { get; set; }

        public ParttimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary) // Call base class constructor
        {
            Wages = wages;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a ParttimeEmployee object
            ParttimeEmployee partTimeEmp = new ParttimeEmployee(101, "Alice", 25000.0f, 20.0f);

            // Display employee details
            Console.WriteLine($"Employee ID: {partTimeEmp.Empid}");
            Console.WriteLine($"Employee Name: {partTimeEmp.Empname}");
            Console.WriteLine($"Base Salary: {partTimeEmp.Salary:C}");
            Console.WriteLine($"Wages (Part-time): {partTimeEmp.Wages:C}");
        }
    }

}
