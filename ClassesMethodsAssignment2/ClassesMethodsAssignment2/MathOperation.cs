using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssignment2
{
    public class MathOperation
    {
        //Takes in two parameters
        //numOne as an int
        //numTwo is an optional parameter, if empty numTwo value will be 1
        //Add numOne and numTwo and return result as an integer
        public int Subtraction(int numOne, int numTwo = 1)
        {
            int result = numOne + numTwo;

            return result; 
        }
    }
}
