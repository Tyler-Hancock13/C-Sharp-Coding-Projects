using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main()
        {
            //PART 1
            string[] random = { "Dog", "Cat", "Rabbit", "Hamster" };

            Console.WriteLine("Enter a color.");
            string input = Console.ReadLine();

            for (int i = 0; i < random.Length; i++)
            {
                Console.WriteLine(random[i] + ": " + input);
            }

            Console.WriteLine("\n");

            //PART 2

            bool infiniteLoop = false;
            while (infiniteLoop == false)
            {
                //Set infiniteLoop to true to avoid an infinite loop
                infiniteLoop = true;
                Console.WriteLine(infiniteLoop);
            }

            //PART 3

            //Sets the iteration condition using <
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            //Sets the iteration condition using <=
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            //PART 4

            List<string> countryList = new List<string>();
            countryList.Add("USA");
            countryList.Add("Canada");
            countryList.Add("France");
            countryList.Add("UK");
            countryList.Add("Germany");

            bool isAMatch = false;
            while (isAMatch == false)
            {
                Console.WriteLine("Enter the name of a country.");
                string country = Console.ReadLine();

                if (countryList.Contains(country))
                {
                    isAMatch = true;
                    Console.WriteLine(countryList.IndexOf(country));
                    Console.ReadLine();
                }

                Console.WriteLine("That country is not in the list.");
            }

            //PART 5
            List<string> duplicateList = new List<string>();
            duplicateList.Add("Cat");
            duplicateList.Add("Dog");
            duplicateList.Add("Horse");
            duplicateList.Add("Cat");

            Console.WriteLine("Enter an animal.");
            string userText = Console.ReadLine();

            bool found = false;

            for(int i = 0; i < duplicateList.Count; i++)
            {
                string currentAnimal = duplicateList[i];

                if (currentAnimal.Contains(userText))
                {
                    Console.WriteLine("{0} is found at index {1}.", currentAnimal, i);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No match found.");
            }

            Console.ReadLine();

            //PART 6
            //This part reuses the duplicateList created in part 5
            List<string> newList = new List<string>();

            foreach(string animal in duplicateList)
            {

                if (newList.Contains(animal))
                {
                    Console.WriteLine("{0} has already appeared.", animal);
                }
                else
                {
                    Console.WriteLine("{0} has not appeared yet.", animal);
                }

                newList.Add(animal);
            }

            Console.ReadLine();
        }
    }
}
