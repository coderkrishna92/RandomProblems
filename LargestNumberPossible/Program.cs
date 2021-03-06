// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace LargestNumberPossible
{
    using System; 

    /// <summary>
    /// This is the main class for the project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">The project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for n to find the largest possible number that is n-digits in length: ");

            int n = int.Parse(Console.ReadLine());

            var largestNumber = FindLargestNumber(n);

            Console.WriteLine($"Given the value of {n}, the largest number possible is {largestNumber}");

            Console.WriteLine("Program execution has completed, press any key to exit");
            Console.ReadKey(); 
        }

        /// <summary>
        /// Ability to find the largest number
        /// </summary>
        /// <param name="n">The number of digits in length</param>
        /// <returns>The largest number, given the length of n-digits</returns>
        static int FindLargestNumber(int n)
        {
            return Convert.ToInt32(Math.Pow(10, n) - 1);
        }
    }
}