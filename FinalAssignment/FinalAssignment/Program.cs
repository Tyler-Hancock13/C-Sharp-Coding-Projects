using FinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code First means to create a database that does not exist yet. Using C# classes you are able to define your model.
            //Using Code First you are able to create a new database or add new tables to it.


            using(var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Bill" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
