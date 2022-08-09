using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            Console.WriteLine(FindSum(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            List<string> wordsList = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            printFive(wordsList);
        }
        static int FindSum(List<int> nums)
        {
            int sum = 0;
            foreach (int x in nums)
            {
                if (x % 2 == 0)
                {
                    sum += x;
                }
            }
            return sum;
        }
        static void printFive(List<string> words)
        {
            Console.Write("Enter a number: ");
            int numOfLetters = int.Parse(Console.ReadLine());
            foreach (string word in words)
            {
                if (word.Length == numOfLetters)
                {
                    System.Console.WriteLine(word);
                }

            }
        }
    }
}
