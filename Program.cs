using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_LINQed_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            IEnumerable<string> LFruits = from fruit in fruits where fruit.Contains("L") select fruit;
            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
            foreach (int number in fourSixMultiples)
            {
                System.Console.WriteLine(number);
            }

            // Output how many numbers are in this list
            List<int> integers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            System.Console.WriteLine($"Amount of numbers in list: {integers.Count()}");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            System.Console.WriteLine($"We have made ${purchases.Sum()}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            System.Console.WriteLine($"Most expensive product costs ${prices.Max()}");

            /*
            Store each number in the following List until a perfect square
            is detected.
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            // var equation = Math.Round(Math.Sqrt(wheresSquaredo.Sum()));
            // System.Console.WriteLine(equation);

            IEnumerable<int> n = wheresSquaredo.TakeWhile(num =>
            {
                int number = Convert.ToInt32(Math.Sqrt(num));
                return number * number != num;
            });
            n.ToList().ForEach(num => Console.WriteLine(num));
        }
    }
}
