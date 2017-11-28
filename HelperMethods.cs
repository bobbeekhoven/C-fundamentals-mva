using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods //shortening code by calling methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");


            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            /* All these green lines have been turned into methods
             
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            


            //string reversedFirstName = ReverseString(firstName);
            //string reversdedLastName = ReverseString(lastName);
            //string reversdedCity = ReverseString(city);
            */

            //method 1
            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city));

            Console.WriteLine();

            //method 2
            DisplayResult(ReverseString(firstName) + "  " +
                ReverseString(lastName) + "  " +
                ReverseString(city));

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {

            //string message = "Hello world!";
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
            /*
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write("  ");
            */
        }
        //method 1
        private static void DisplayResult(
            string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }

        //method 2
        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);

        }
    }
}
