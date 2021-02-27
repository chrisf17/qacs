using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise15.MoreLinQ
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public decimal Salary { get; set; }
    }
    class MainClass
    {
        public static int[] numbers = { 12, 22, 34, 11, 15, 100, 201, 99 };
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee { FirstName = "Fred", LastName="Bloggs", Age=41, Salary=30000m },
            new Employee { FirstName = "Amy", LastName="Anderson", Age=22, Salary=50000m },
            new Employee { FirstName = "Jaz", LastName="Jones", Age=28, Salary=50000m },
            new Employee { FirstName = "Mina", LastName="Mi", Age=31, Salary=30000m },
            new Employee { FirstName = "Beth", LastName="Bethany", Age=31, Salary=80000m }


        };
        public static void Main(string[] args)
        {

            // Do the following, comment out what you after done after each step
            // Uncomment the line below to run the Solution
            // Solution.Run();

            // 1. Display the total of all the numbers array
            // 2. Display the total of numbers less than 100
            // 3. Display Employee total Salaries
            // 4. Display Average Salaries

            // Using the keyword (SQL like syntax)
            // 5. Display list of Employees older than 30 ordered by LastName
            // 6. Display only Employees whose lastname starts with B - HINT strings have a StartsWith method
            // 7. Retrieve and display FirstName, Salary of Employes with a salary greater than 30000
            // If you have time 
            // 8. Try doing questions 5 and 6 using lamda syntax
            // 9. Group Employees by Salary and display which Employees belog to which Salaries



        }


    }
}
