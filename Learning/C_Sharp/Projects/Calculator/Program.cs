
global using global::System;
global using global::System.Collections.Generic;

using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace Calculator
{

    public class SimpleCalculator
    {

        public static void Main()
        {
            // Run the main program
            RunProgram();

            // Run benchmarks if the "BENCHMARK" conditional compilation symbol is defined
            RunBenchmarks();
        }

        // Method to run benchmarks (conditionally compiled)
        [Conditional("BENCHMARK")]
        public static void RunBenchmarks()
        {
            // Run benchmarks using BenchmarkRunner for the FactorAlgorithmBenchmarks class
            BenchmarkRunner.Run<FactorAlgorithmBenchmarks>();
            // Wait for a key press before closing the console (useful for observing benchmark results)
            Console.ReadKey();
        }

        // Method to run the main program (conditionally compiled for both "DEBUG" and "RELEASE")
        [Conditional("DEBUG")]
        [Conditional("RELEASE")]
        public static void RunProgram()
        {
            // Infinite loop for the calculator menu
            while (true)
            {
                // Display menu options
                Console.WriteLine("[Menu] |-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-|");
                Console.WriteLine("[Menu] | You can use this Simple Calculator for:               |");
                Console.WriteLine("[Menu] | ADDITION: Enter '+' to perform Addition.              |");
                Console.WriteLine("[Menu] | SUBTRACTION: Enter '-' to perform Subtraction         |");
                Console.WriteLine("[Menu] | MULTIPLICATION: Enter '*' to perform Multiplication   |");
                Console.WriteLine("[Menu] | DIVISION: Enter '/' to perform Division               |");
                Console.WriteLine("[Menu] | FACTOR: Enter 'factor' to run factorization algorithm |");
                Console.WriteLine("[Menu] | EXIT: Enter 'exit' to exit the calculator             |");
                Console.WriteLine("[Menu] |-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-|");

                // Take user input
                Console.Write("[Input]: ");
                string? userInput = Console.ReadLine();

                // Handle cases where user input is null or empty
                if (userInput == null || userInput == "")
                {
                    Console.WriteLine("[Error]: Enter a valid choice.");
                    continue;
                }

                // Check if the user wants to exit
                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("[Exit] Exiting the calculator. Goodbye!");
                    break;
                }


                if (userInput.ToLower() == "factor")
                {
                    // Factorization option
                    Console.Write("[Number]: Enter the number to factorize: ");
                    if (!int.TryParse(Console.ReadLine(), out int numberToFactorize))
                    {
                        Console.WriteLine("[Error] Invalid input for factorization. Please enter a valid integer.");
                        continue;
                    }

                    var factors = Core.OptimizedFactorAlgorithm(numberToFactorize);
                    Console.WriteLine($"[Result] Factors of {numberToFactorize}: {string.Join(", ", factors)}"); 
                    var factors2 = Core.SimpleFactorAlgorithm(numberToFactorize);
                    Console.WriteLine($"[Result] Factors of {numberToFactorize}: {string.Join(", ", factors2)}");
                    continue;
                }

                // Take in numbers for the calculation
                Console.Write("[Number]: Enter the first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("[Error] Invalid input for the first number. Please enter a valid number.");
                }

                Console.Write("[Number]: Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("[Error] Invalid input for the second number. Please enter a valid number.");
                }

                double result;
                // Perform the selected operation based on user input
                switch (userInput)
                {
                    case "+":
                        result = Core.Add(num1, num2);
                        Console.WriteLine($"[Result] Addition: {result}");
                        break;
                    case "-":
                        result = Core.Sub(num1, num2);
                        Console.WriteLine($"[Result] Subtraction: {result}");
                        break;
                    case "*":
                        result = Core.Mul(num1, num2);
                        Console.WriteLine($"[Result] Multiplication: {result}");
                        break;
                    case "/":
                        try
                        {
                            result = Core.Div(num1, num2);
                            Console.WriteLine($"[Result] Division: {result}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"[Error] {ex.Message}");
                        }
                        break;
                    default:
                        Console.WriteLine("[Error] Invalid operation. Please enter a valid operation.");
                        break;
                }
            }
        }
    }
}