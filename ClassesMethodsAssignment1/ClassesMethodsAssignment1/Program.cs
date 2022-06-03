using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation math = new MathOperation();

            //Call the Addition method and pass in an integer value of 100
            Console.WriteLine(math.Addition(100));

            //Call the Addition method and pass in a decimal value of 5.5
            Console.WriteLine(math.Addition(5.5m));

            //Call the Addition method and pass in a string value of 'Hello World'
            Console.WriteLine(math.Addition("Hello World"));
            Console.ReadLine();
        }
    }
}
