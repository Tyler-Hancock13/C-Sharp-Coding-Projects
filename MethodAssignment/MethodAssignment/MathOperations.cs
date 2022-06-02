using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class MathOperations
    {
        //Takes in an int as a parameter and multiplies the parameter by 10 and returns the result
        public int Multiply(int num)
        {
            int result = num * 10;

            return result;
        }

        //Takes in an int as a parameter and divides the parameter by 2 and returns the result
        public int Divide(int num)
        {
            int result = num / 2;

            return result;
        }

        //Takes in an int as a parameter and adds the parameter by 25 and returns the result
        public int Add(int num)
        {
            int result = num + 25;

            return result;
        }
    }
}
