using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MathOperations math = new MathOperations();

                //Get the number the user would like to perform the math operations on
                Console.WriteLine("Enter a value to do math operations on.");
                int userValue = Convert.ToInt32(Console.ReadLine());

                //Call the three math methods and display the returned integer to the user
                Console.WriteLine(userValue + " / 2 = " + math.Divide(userValue));
                Console.WriteLine(userValue + " * 10 = " + math.Multiply(userValue));
                Console.WriteLine(userValue + " + 25 = " + math.Add(userValue));
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
