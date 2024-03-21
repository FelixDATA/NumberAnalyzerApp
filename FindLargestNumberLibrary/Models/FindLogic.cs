using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestNumberLibrary.Models
{
    public class FindLogic
    {
        public static string AskForInput()
        {
            string userInput = "";

            do
            {
                Console.WriteLine($"Please input numbers, separated by comma");
                userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("You didn't input any numbers");
                    Console.WriteLine();
                }

            } while (string.IsNullOrEmpty(userInput));
            return userInput;
        }

        public static List<int> ConvertInputToList()
        {

            List<int> numbers = new List<int>();
            bool conversionSuccessful = false;

            while (!conversionSuccessful)
            {
                string userInput = AskForInput();

                try
                {
                    numbers = userInput.Split(',')
                                       .Select(s => s.Trim())
                                       .Select(int.Parse)
                                       .ToList();
                    conversionSuccessful = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("One or more items in the input are not valid integers. Please follow the input format (e.g., 1,2,3).");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("One or more items in the input are too large or too small for an integer.");
                }
            }
            return numbers;

        }

        public static void DisplayNumbers(List<int> numbers)
        {
            Console.WriteLine("The numbers you have input are:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }


        public static int FindLargestNumber(List<int> numbers)
        {
            int max = 0;

            Console.WriteLine();
            Console.WriteLine("Trying to find the largest number...");

            max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
    }
}
