﻿
// See https://aka.ms/new-console-template for more information
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
            Console.WriteLine("2 for Perfect Number Problem");
            Console.WriteLine("3 for Prime Number Problem");
            Console.WriteLine("4 for Reverse Number Problem");
            Console.WriteLine("5 for Coupon Number Problem");
            Console.WriteLine("6 for Stop Watch Problem");

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Fibonaaci();
                    break;
                case 2:
                    PerfectNumberProblems perfectNumberProblems = new PerfectNumberProblems();
                    perfectNumberProblems.PerfectNumber();
                    break;
                case 3:
                    ProbPrimeNumber prob = new ProbPrimeNumber();
                    prob.PrimeNumbers();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;
                case 5:
                    Console.Write("How many numbers you wants to generate: ");
                    int N = Convert.ToInt32(Console.ReadLine());
                    CouponNumber.Coupon(N);
                    break;
                case 6:
                    StopWatchProblem stopWatchProblem = new StopWatchProblem();
                    stopWatchProblem.StopWatch();
                    break;


            }
        }
    }
}