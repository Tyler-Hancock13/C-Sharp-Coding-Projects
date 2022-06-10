using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.isEmployed = true;

            employee.SayName();

            employee.Quit(employee.isEmployed);
            employee.isEmployed = false;

            Console.ReadLine();
        }
    }
}
