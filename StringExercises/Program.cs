﻿using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");
            string myString = "I would not, could not, in a box. I would not, could not with a fox.\nI will not eat them in a house. I will not eat them with a mouse.";
            string[] myArray = myString.Split(".");
            Console.WriteLine(string.Join(", ", myArray));
        }
    }
}
