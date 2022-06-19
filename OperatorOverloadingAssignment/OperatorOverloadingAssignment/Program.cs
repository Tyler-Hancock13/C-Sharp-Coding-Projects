using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee();
            employeeOne.Id = 1;
            employeeOne.FirstName = "John";
            employeeOne.LastName = "Doe";

            Employee employeeTwo = new Employee();
            employeeTwo.Id = 1;
            employeeOne.FirstName = "Tyler";
            employeeTwo.LastName = "Hancock";

            Employee employeeThree = new Employee();
            employeeThree.Id = 3;
            employeeThree.FirstName = "Dave";
            employeeThree.LastName = "Good";

            if(employeeOne == employeeTwo)
            {
                Console.WriteLine("Employee ID's are equal. ID 1 and 1");
            }
            else
            {
                Console.WriteLine("Employee ID's are not equal.");
            }
            
            if(employeeTwo != employeeThree)
            {
                Console.WriteLine("Employee ID's are not equal. ID 1 and 3");
            }
            else
            {
                Console.WriteLine("Employee ID's are equal.");
            }
            Console.ReadLine();
        }
    }
}
