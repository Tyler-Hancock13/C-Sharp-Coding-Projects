using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current local time is: {0}", DateTime.Now);

            Console.WriteLine("\nPlease enter a number.");
            int hours = Convert.ToInt32(Console.ReadLine());

            DateTime futureDate = DateTime.Now.AddHours(hours);
            Console.WriteLine("In {0} hours the date and time will be:\n{1}", hours, futureDate);
            Console.ReadLine();
        }
    }
}
