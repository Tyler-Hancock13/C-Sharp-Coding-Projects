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
            //Employee employee = new Employee();
            //IQuittable iEmployee = employee;
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.isEmployed = true;

            //employee.SayName();

            //employee.Quit(employee.isEmployed);
            //employee.isEmployed = false;
            IQuittable iemp = new Employee() { FirstName = "Tyler", LastName = "Hancock", isEmployed = true };
            iemp.Quit(true);

            Console.ReadLine();
        }
    }
}
