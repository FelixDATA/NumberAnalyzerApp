using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindLargestNumberLibrary.Models;

namespace FindLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            DataModel data = new DataModel();

            data.Numbers = FindLogic.ConvertInputToList();
            FindLogic.DisplayNumbers(data.Numbers);

            int max = FindLogic.FindLargestNumber(data.Numbers);
            Console.WriteLine("The largest number is: " + max + "!");

            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcom to Find Largest Number App!");
            Console.WriteLine("This App is created by Felix");
            Console.WriteLine();
        }
    }
}