using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3
{
    class EmployeeProgram
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>
            {
                new Employee { EmpId = 1001, EmpFirstName = "Malcolm", EmpLastName = "Daruwalla", 
                    Title = "AsstManager", EmpDOB = new DateTime(1984, 11, 16), 
                    EmpDOJ = new DateTime(2011, 6, 8), EmpCity = "Mumbai" },
                new Employee { EmpId = 1003, EmpFirstName = "Madhavi", EmpLastName = "Sharma",
                    Title = "Consultant", EmpDOB = new DateTime(1987, 11, 14), 
                    EmpDOJ = new DateTime(2015, 4, 12), EmpCity = "Pune" },
            };

            EmployeeProgram ep = new EmployeeProgram();
            ep.EmployeeList(list);
            ep.EmployeeNotInMumbai(list);
            ep.AsstManagerTitle(list);
            ep.StartNameWith_S(list);
            Console.ReadKey();

        }

        public void EmployeeList(List<Employee> list)
        {
            foreach (var employee in list)
            {
                Console.WriteLine($"{employee.EmpId} - {employee.EmpFirstName} {employee.EmpLastName}, " +
                    $"{employee.Title}, DOB: {employee.EmpDOB.ToShortDateString()}," +
                    $" DOJ: {employee.EmpDOJ.ToShortDateString()}, City: {employee.EmpCity}");
            }
        }

        public void EmployeeNotInMumbai(List<Employee> list)
        {
            var nonMumbaiEmp = list.Where(emp => emp.EmpCity != "Mumbai");
            foreach (var emp in nonMumbaiEmp)
            {
                Console.WriteLine($"Employees not in Mumbai: { emp.EmpId} - {emp.EmpFirstName} {emp.EmpLastName}, City: {emp.EmpCity}");
            }
        }

        public void AsstManagerTitle(List<Employee> list)
        {
            var titleAsstManager = list.Where(emp => emp.Title == "AsstManager");
            foreach(var emp in titleAsstManager)
            {
                Console.WriteLine($"Employees whose title is AsstManager: {emp.EmpId}, {emp.EmpFirstName} {emp.EmpLastName}, {emp.EmpCity}");
            }
        }

        public void StartNameWith_S(List<Employee> list)
        {
            var startWith_S = list.Where(emp => emp.EmpLastName.StartsWith("S"));
            foreach (var emp in startWith_S)
            {
                Console.WriteLine($"Employees whose Last Name start with S: {emp.EmpId}, {emp.EmpFirstName}, {emp.EmpLastName}, {emp.EmpCity}");
            }
        }
 }
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string Title  { get; set; }
        public DateTime EmpDOB { get; set; }
        public DateTime EmpDOJ { get; set; }
        public string EmpCity { get; set; }



    }
}
