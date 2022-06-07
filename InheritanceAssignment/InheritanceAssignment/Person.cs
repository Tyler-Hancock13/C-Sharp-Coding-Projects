using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Person
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        //Displays the FirstName and LastName attributes in the console
        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
