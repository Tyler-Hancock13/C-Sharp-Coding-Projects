using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main()
        {
            //Initialize string array with values
            string[] stringArray = { "Zero", "One", "Two", "Three" };

            //Initialize int array with values
            int[] intArray = { 50, 33, 100, 123, 40 };

            //Initialize list of type string and add values to the list
            List<string> stringList = new List<string>();
            stringList.Add("Dog");
            stringList.Add("Cat");
            stringList.Add("Bird");
            stringList.Add("Rabbit");

            //Initialize a boolean as false and using a while loop to restart if the user enters an invalid index
            bool i = false;
            while(i == false)
            {
                //Get the number entered by the user and display the string at that index
                Console.WriteLine("Enter a number between 0 and 3");
                int stringIndex = Convert.ToInt32(Console.ReadLine());

                //Check if the index entered by the user is less than the number of indexes in the array as well as if the number is less than 0 to
                //account to negative numbers
                if (stringIndex > stringArray.Length - 1 || stringIndex < 0)
                {
                    Console.WriteLine("You entered an invalid number. Please try again. \n");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(stringArray[stringIndex] + "\n");
                    i = true;
                }
            }

            //Repeat the process for the int array
            bool j = false;
            while(j == false)
            {
                Console.WriteLine("Enter a number between 0 and 4");
                int intIndex = Convert.ToInt32(Console.ReadLine());

                if (intIndex > intArray.Length - 1 || intIndex < 0)
                {
                    Console.WriteLine("You entered an invalid number. Please try again. \n");
                }
                else
                {
                    Console.WriteLine(intArray[intIndex].ToString() + "\n");
                    j = true;
                }
            }

            //Repeat the process again for the string list
            bool x = false;
            while(x == false)
            {
                Console.WriteLine("Enter a number between 0 and 3");
                int listIndex = Convert.ToInt32(Console.ReadLine());

                if (listIndex > stringList.Count - 1 || listIndex < 0)
                {
                    Console.WriteLine("You entered an invalid number. Please try again. \n");
                }
                else
                {
                    Console.WriteLine(stringList[listIndex].ToString());
                    Console.ReadLine();
                }
            }
        }
    }
}
