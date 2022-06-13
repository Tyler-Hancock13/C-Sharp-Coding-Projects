using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool validAnswer = false;
                int age = 0;

                while (!validAnswer)
                {
                    Console.WriteLine("Enter your age.");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);

                    if (!validAnswer) Console.WriteLine("You can only enter digits with no decimals.");
                }

                if(age < 1)
                {
                    throw new NegativeException();
                }

                int userBirthYear = DateTime.Now.Year - age;
                Console.WriteLine("You were born in {0}", userBirthYear);
                Console.ReadLine();
            }
            catch (NegativeException)
            {
                Console.WriteLine("Age must be greater than 0.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }
        }
    }
}
