using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Use virtual to add implementation
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
