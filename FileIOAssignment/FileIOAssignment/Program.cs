using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\tyler\Desktop\numLog.txt", true))
            {
                file.WriteLine(number);
            }

            Console.WriteLine("File was successfully created.");
            Console.WriteLine("Retrieving data from file...\n");

            using(StreamReader readText = new StreamReader(@"C:\Users\tyler\Desktop\numLog.txt"))
            {
                string text = readText.ReadToEnd();
                Console.WriteLine(text);
            }


            Console.ReadLine();
        }
    }
}
