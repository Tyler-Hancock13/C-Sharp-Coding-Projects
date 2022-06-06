using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperation class and create numOne and numTwo variables
            MathOperation math = new MathOperation();
            int numOne = 2;
            int numTwo = 25;

            //Call the MathOperationAndDisplay method in the MathOperation class
            //Pass in the numOne and numTwo variables from above
            math.MathOperationAndDisplay(numOne, numTwo);
            Console.ReadLine();
        }
    }
}
