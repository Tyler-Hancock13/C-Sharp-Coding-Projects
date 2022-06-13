using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string welcomeMessage = "Welcome to MegaCorp.";
            var employeeNoDepartment = new Employee("Tyler", "Hancock");
            var supervisor = new Employee("John", "Doe", "Human Resources");
            Console.WriteLine("{0} Please view your information below.\n\nYour name is {1} {2} and you are assigned to: {3}", welcomeMessage, employeeNoDepartment.FirstName, employeeNoDepartment.LastName, employeeNoDepartment.Department);
            Console.WriteLine("Your supervisor is {0} {1} in the department {2}", supervisor.FirstName, supervisor.LastName, supervisor.Department);
            Console.ReadLine();
        }
    }
}
