﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to Logical programming computation problem");

using System;

namespace LogicalProblem

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Logical Problems");
            Console.WriteLine("1 for Fibonacci Series Problem");

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Fibonaaci();
                    break;

            }
        }
    }
}