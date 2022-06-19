using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public static class MathOperation
    {
        public static void Divide(int num)
        {
            int result = num / 2;

            Console.WriteLine("{0} divided by 2 is {1}", num, result);
        }

        public static int Multiply(int num)
        {
            return num * 2;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
    }
}
