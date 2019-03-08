﻿namespace StructBasicsProblem1
{
    using System;

    /// <summary>
    /// Having the ability to set values as part of a struct data
    /// type in C# - where the members are public by default
    /// </summary>
    struct ValuesStruct
    {
        public int x;
        public int y; 
    }

    /// <summary>
    /// With the classes, you can have members in a class, however
    /// by default they are private as opposed to structs where the
    /// members of structs are actually public by default
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n Declaring a simple structure: \n");
            Console.Write("-----------------------------------\n");

            ValuesStruct primaryStruct = new ValuesStruct
            {
                x = int.Parse(Console.ReadLine()), 
                y = int.Parse(Console.ReadLine())
            };

            int sum = primaryStruct.x + primaryStruct.y;
            Console.WriteLine($"The sum of {primaryStruct.x} and {primaryStruct.y} is {sum}");

            Console.WriteLine("Execution of this program has completed. You may now press any key to exit");
            Console.ReadKey(); 
        }
    }
}