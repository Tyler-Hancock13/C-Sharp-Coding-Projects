using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MathOperation math = new MathOperation();

                Console.WriteLine("You will enter two numbers. The second number is optional. \nEnter the first number.");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();

                Console.WriteLine("Enter the second number. Leave blank if you would not like to enter a second number.");

                string isEmpty = Console.ReadLine(); //Assign the user entered value to a string called isEmpty

                if (isEmpty == string.Empty) //Check if isEmpty is an empty string
                {
                    //If empty execute the method with only numOne argument
                    Console.WriteLine(math.Subtraction(numOne));
                }
                else
                {
                    //If not empty convert the string value to an integer
                    int numTwo = Convert.ToInt32(isEmpty);
                    Console.WriteLine(math.Subtraction(numOne, numTwo)); //Execute method with both arguments
                }

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
