using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that will be both multiplied and divided.");
            int num = Convert.ToInt32(Console.ReadLine());
            MathOperation.Divide(num);

            int multiplyResult = MathOperation.Multiply(num);
            Console.WriteLine("{0} multiplied by 2 is {1}", num, multiplyResult);

            Console.WriteLine("\n\nEnter a second number.");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int multiplyOverload = MathOperation.Multiply(num, numTwo);
            Console.WriteLine("\n{0} multiplied by {1} is {2}", num, numTwo, multiplyOverload);

            Console.ReadLine();
        }
    }
}
