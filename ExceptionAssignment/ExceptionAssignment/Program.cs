using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Initialize list of integers to divide
                List<int> divisionList = new List<int>();
                divisionList.Add(22);
                divisionList.Add(63);
                divisionList.Add(10);
                divisionList.Add(15);

                //User enters the number they would like to divide by
                Console.WriteLine("Enter a number to divide by.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");

                //Using a foreach loop, iterate through the list and divide the
                //numbers in the list with the number the user entered
                foreach (int num in divisionList)
                {
                    Console.WriteLine(num / userNumber);
                }
            }
            //If the user enters a non-integer value, or if they enter 0 or any other error is
            //detected the error message will be displayed to the user
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0.");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("You must enter a whole number.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //After the try/catch block is executed the finally block is executed
            finally
            {
                Console.WriteLine("This text is outside of the try/catch block.");
                Console.ReadLine();
            }
            
        }
    }
}
