
global using global::System;

namespace Calculator
{

    public class SimpleCalculator
    {

        public static void Main()
        {
            while (true)
            {
                // Show menu
                Console.WriteLine("[Menu] |-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-|");
                Console.WriteLine("[Menu] | You can use this Simple Calculator for:               |");
                Console.WriteLine("[Menu] | ADDITION: Enter '+' to perform Addition.              |");
                Console.WriteLine("[Menu] | SUBTRACTION: Enter '-' to perform Subtraction         |");
                Console.WriteLine("[Menu] | MULTIPLICATION: Enter '*' to perform Multiplication   |");
                Console.WriteLine("[Menu] | DIVISION: Enter '/' to perform Division               |");
                Console.WriteLine("[Menu] | EXIT: Enter 'exit' to exit the calculator             |");
                Console.WriteLine("[Menu] |-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-|");

                // Take Response.
                Console.Write("[Input]: ");
                string? userInput = Console.ReadLine();
                // User doesn't pass anything.
                if (userInput == null || userInput=="")
                {
                    Console.WriteLine("[Error]: Enter a valid choice.");
                    continue;
                }
                // Asked to exit.
                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("[Exit] Exiting the calculator. Goodbye!");
                    break;
                }

                // Take in Numbers
                double num1, num2, result;
                Console.Write("[Number]: Enter the first number: ");
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("[Error] Invalid input for the first number. Please enter a valid number.");
                }
                Console.Write("[Number]: Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("[Error] Invalid input for the second number. Please enter a valid number.");
                }

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

                //  =-=-=-=-=-=-

            }
        }
    }
}