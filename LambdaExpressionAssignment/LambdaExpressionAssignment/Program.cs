using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            Employee empOne = new Employee() { FirstName = "Joe", LastName = "Legere", Id = 1 };
            empList.Add(empOne);

            Employee empTwo = new Employee() { FirstName = "John", LastName = "Malcolm", Id = 2 };
            empList.Add(empTwo);

            Employee empThree = new Employee() { FirstName = "Matt", LastName = "Yuge", Id = 3 };
            empList.Add(empThree);

            Employee empFour = new Employee() { FirstName = "Peter", LastName = "Scott", Id = 4 };
            empList.Add(empFour);

            Employee empFive = new Employee() { FirstName = "Elizabeth", LastName = "Cooke", Id = 5 };
            empList.Add(empFive);

            Employee empSix = new Employee() { FirstName = "Tom", LastName = "Wilson", Id = 6 };
            empList.Add(empSix);

            Employee empSeven = new Employee() { FirstName = "Joe", LastName = "Pierre", Id = 7 };
            empList.Add(empSeven);

            Employee empEight = new Employee() { FirstName = "Cathy", LastName = "Luke", Id = 8 };
            empList.Add(empEight);

            Employee empNine = new Employee() { FirstName = "Jeff", LastName = "Cann", Id = 9 };
            empList.Add(empNine);

            Employee empTen = new Employee() { FirstName = "Rob", LastName = "Bee", Id = 10 };
            empList.Add(empTen);

            //foreach(Employee emp in empList)
            //{
            //    if(emp.FirstName == "Joe")
            //    {
            //        Console.WriteLine(emp.FirstName + emp.LastName + emp.Id);
            //    }
            //}

            //Make a new list called joeList that will add in any employee's who have the first name Joe
            List<Employee> joeList = empList.Where(x => x.FirstName == "Joe").ToList();

            //Loop through the list of joe's to display in the console
            foreach(Employee joe in joeList)
            {
                Console.WriteLine(joe.Id + " " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine("\n");


            //Make a new list called idList that will add all employees from empList with an id greater than 5
            List<Employee> idList = empList.Where(x => x.Id > 5).ToList();

            //Loop through idList and display employee information
            foreach(Employee emp in idList)
            {
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            }

            Console.ReadLine();
        }
    }
}
