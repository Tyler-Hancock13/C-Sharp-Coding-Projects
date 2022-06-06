using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssignment3
{
    public class MathOperation
    {
        //A void method that does not need to return anything
        //Multiply numOne by 2
        //Display numTwo in console
        public void MathOperationAndDisplay(int numOne, int numTwo)
        {
            int result = numOne * 2;
            Console.WriteLine(numOne + " * 2 = " + result);
            Console.WriteLine("The second number was " + numTwo);
        }
    }
}
