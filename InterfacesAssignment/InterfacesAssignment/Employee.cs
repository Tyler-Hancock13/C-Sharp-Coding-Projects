using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    public class Employee:Person, IQuittable
    {
        //Used to determine if employee has already quit or not
        public bool isEmployed { get; set; }
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit(bool isEmployed)
        {
            if(isEmployed == true)
            {
                Console.WriteLine("You quit!");
            }
            else
            {
                Console.WriteLine("You can't quit!");
            }
        }
    }
}
