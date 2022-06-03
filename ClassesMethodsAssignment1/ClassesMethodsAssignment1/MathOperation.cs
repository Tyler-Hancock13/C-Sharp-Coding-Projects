using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssignment1
{
    public class MathOperation
    {
        //Takes in an integer parameter and adds 100 to the value
        //Returns sum as integer
        public int Addition(int value)
        {
            int result = value + 100;

            return result;
        }

        //Takes in a decimal parameter and adds 5.5 to the value
        //Returns sum as integer
        public int Addition(decimal value)
        {
            decimal result = value + 5.5m;
            int intResult = Convert.ToInt32(result);

            return intResult;
        }

        //Takes in a string parameter and gets the length of that string as an int
        //String length is added to 20
        //Returns sum as integer
        public int Addition(string value)
        {
            int result = value.Length + 20;

            return result;
        }
    }
}
