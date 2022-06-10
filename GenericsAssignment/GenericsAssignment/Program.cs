using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeOne = new Employee<string>();
            employeeOne.Things = new List<string>() { "Jack", "John", "Bob", "Dave" };
            Employee<int> employeeTwo = new Employee<int>();
            employeeTwo.Things = new List<int>() { 1, 2, 3, 4, 5 };

            foreach(string thing in employeeOne.Things)
            {
                Console.WriteLine(thing);
            }

            foreach(int thing in employeeTwo.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
