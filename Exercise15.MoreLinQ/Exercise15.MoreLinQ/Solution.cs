using System;
using System.Linq;

namespace Exercise15.MoreLinQ
{
    
    public class Solution
    {
        public static void Run()
        {
            Console.WriteLine("*********************\nSolution");
            // 1. Display the total of all the numbers array
            Console.WriteLine(MainClass.numbers.Sum());
            // 2. Display the total of numbers less than 100
            Console.WriteLine(MainClass.numbers.Sum(n => n < 100 ? n : 0));
            // 3. Display Employee total Salaries
            Console.WriteLine(MainClass.employees.Sum(e => e.Salary));
            // 4. Display Average Salaries
            Console.WriteLine(MainClass.employees.Average(e => e.Salary));

            // Using the keyword (SQL like syntax)
            // 5. Display list of Employees older than 30 ordered by LastName
            var emps1 = from e in MainClass.employees
                        where e.Age > 30
                        orderby e.LastName
                        select e;
            foreach (var employee in emps1)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            // 6. Display only Employees whose lastname starts with B
            var emps2 = from e in MainClass.employees
                        where e.LastName.StartsWith("B")
                        select e;
            foreach (var employee in emps2)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            // 7. Retrieve and display FirstName, Salary of Employes with a salary greater than 30000
            var emps3 = from e in MainClass.employees
                        where e.Salary > 30000
                        select new { e.FirstName, e.Salary };
            foreach (var data in emps3)
            {
                Console.WriteLine($"{data.FirstName} earns {data.Salary}");
            }

            // If you have time 
            // 8. Try doing question 5 using lamda syntax
            var emps4 = MainClass.employees.Where(e => e.Age > 30)
                                 .OrderBy(e => e.LastName);
            foreach (var employee in emps4)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            // 9. Group Employees by Salary and display which Employees belog to which Salaries
            var employeeGroups = from e in MainClass.employees
                                 group e by e.Salary;

            foreach(var eGroup in employeeGroups)
            {
                Console.WriteLine($"Group For Salary: {eGroup.Key}");
                foreach(var emp in eGroup)
                {
                    Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
                }
            }
        }

    }
}
