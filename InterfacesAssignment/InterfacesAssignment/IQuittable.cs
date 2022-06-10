using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssignment
{
    interface IQuittable
    {
        //Quit method that returns void and has one boolean parameter named isEmployed
        void Quit(bool isEmployed);
    }
}
