﻿namespace AcronymMaker
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase to abbreviate: ");
            string inputString = Console.ReadLine();

            Abbreviate(inputString);
            Console.WriteLine("Your program has finished execution - you may press any key to exit");
            Console.ReadKey(); 
        }

        public static string Abbreviate(string input)
        {
            var parts = input.Split(new char[] { ' ', '-', '_' });
            Console.WriteLine("parts: ");
            string res = "";
            foreach (var p in parts)
            {
                Console.WriteLine(p);
                if (p.Length > 0)
                {
                    res += p.ToUpper()[0]; 
                }
            }

            Console.WriteLine("res: {0}", res);
            return res; 
        }
    }
}