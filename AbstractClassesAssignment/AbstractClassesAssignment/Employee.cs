using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    public class Employee:Person
    {
        //Call the base SayName method
        public override void SayName()
        {
            base.SayName();
        }
    }
}
