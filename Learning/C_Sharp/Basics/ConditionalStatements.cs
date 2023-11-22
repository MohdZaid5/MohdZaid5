
namespace C_Sharp.Basics
{
    public class ConditionalStatements
    {
        public static void Example()
        {
            /* Introduction to if and else Statements in C#:
             * 
             * In C#, the if and else statements are used for conditional branching, allowing the program to make decisions based on specified conditions.
             * These statements control the flow of the program by executing different blocks of code depending on whether a given condition is true or false.
             */
            // Syntax of if statement:
            int number = 10;
            if (number > 0)
            {
                // Code to be executed if the condition is true
                Console.WriteLine("[>] The number is positive.");
            }
            // Syntax of if-else statement:
            int anotherNumber = -5;
            if (anotherNumber > 0)
            {
                // Code to be executed if the condition is true
                Console.WriteLine("[>] The number is positive.");
            }
            else
            {
                // Code to be executed if the condition is false
                Console.WriteLine("[>] The number is non-positive.");
            }
            /* Key Points:
             * - The condition inside the if statement is enclosed in parentheses and must evaluate to a boolean value (true or false).
             * - The block of code following the if statement is executed if the condition is true.
             * - The else statement provides an alternative block of code to be executed if the condition in the if statement is false.
             * - Braces { } are used to define blocks of code. Even if a block contains only one statement, it's a good practice to use braces for clarity.
             * - The else statement is optional; you can use only the if statement if no alternative action is needed.
             */
            // Example: Determining the type of a number
            int userInput = 0;
            if (userInput > 0)
            {
                Console.WriteLine("[>] The entered number is positive.");
            }
            else if (userInput < 0)
            {
                Console.WriteLine("[>] The entered number is negative.");
            }
            else
            {
                Console.WriteLine("[>] The entered number is zero.");
            }
            /* Tips:
             * - Use meaningful variable names and conditions to enhance code readability.
             * - Proper indentation helps maintain code structure and improves readability.
             * - Be cautious with nested if-else structures; they can become complex. Consider refactoring for better clarity.
             * - Use if-else statements to handle different cases or scenarios within your program.
             */


            /* Example of Nested If-Else:
             * 
             * In this example, we determine the grade of a student based on their score.
             * The nested if-else structure checks multiple conditions sequentially.
             * While it works, nesting can make the code less readable and harder to maintain as conditions increase.
             */
            int studentScore = 75;
            if (studentScore >= 90)
            {
                Console.WriteLine("[>] Grade: A");
            }
            else
            {
                if (studentScore >= 80)
                {
                    Console.WriteLine("[>] Grade: B");
                }
                else
                {
                    if (studentScore >= 70)
                    {
                        Console.WriteLine("[>] Grade: C");
                    }
                    else
                    {
                        if (studentScore >= 60)
                        {
                            Console.WriteLine("[>] Grade: D");
                        }
                        else
                        {
                            Console.WriteLine("[>] Grade: F");
                        }
                    }
                }
            }

            /* Refactored Example without Nesting:
             * 
             * Refactoring involves restructuring the code to improve readability and maintainability.
             * Here, we use a series of if statements without nesting to achieve the same result more straightforwardly.
             */
            if (studentScore >= 90)
            {
                Console.WriteLine("[>] Grade: A");
            }
            else if (studentScore >= 80)
            {
                Console.WriteLine("[>] Grade: B");
            }
            else if (studentScore >= 70)
            {
                Console.WriteLine("[>] Grade: C");
            }
            else if (studentScore >= 60)
            {
                Console.WriteLine("[>] Grade: D");
            }
            else
            {
                Console.WriteLine("[>] Grade: F");
            }
        }

        public static void Example2()
        {
            /* Introduction to Switch-Case Statements in C#:
             * 
             * The switch-case statement in C# provides an alternative way to handle multiple conditions in a more concise and structured manner.
             * It is especially useful when you have a single expression or variable to compare against different values.
             * Switch-case simplifies code and enhances readability compared to using multiple if-else statements.
             */
            // Syntax of Switch-Case:
            int dayOfWeek = 3;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("[>] It's Monday.");
                    break;
                case 2:
                    Console.WriteLine("[>] It's Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("[>] It's Wednesday.");
                    break;
                // ... additional cases for other days
                default:
                    Console.WriteLine("[>] It's another day.");
                    break;
            }
            /* Key Points:
             * - The switch keyword is followed by the expression (variable) to be evaluated.
             * - Each case label represents a possible value for the expression.
             * - The break statement is used to exit the switch block after a case is matched.
             * - The default case is optional and is executed if none of the cases match the expression.
             * - You can have multiple statements within each case block.
             */
            // Example: Switch-case for handling menu choices
            char userChoice = 'A';
            switch (userChoice)
            {
                case 'A':
                    Console.WriteLine("[>] Selected option: View Profile");
                    break;
                case 'B':
                    Console.WriteLine("[>] Selected option: Edit Settings");
                    break;
                case 'C':
                    Console.WriteLine("[>] Selected option: Logout");
                    break;
                default:
                    Console.WriteLine("[>] Invalid choice");
                    break;
            }
            /* Tips:
             * - Keep each case concise and focused on a specific value or range.
             * - Use break statements to prevent fall-through (execution of subsequent cases).
             * - Consider using the switch-case statement when you have a series of conditions based on the same expression.
             */

            /* Example of Switch Statement without Break:
             * 
             * In this example, we demonstrate what happens when there is no 'break' statement after each case.
             * The control falls through to subsequent cases, and their code is executed even if their conditions are not met.
             */
            switch (dayOfWeek)
            {
                case 1:
                case 2:
                    Console.WriteLine("[>] It's Tuesday.");
                    break;
                default:
                    Console.WriteLine("[>] It's another day.");
                    break;
            }
            /* Example of Intentional Fall-Through:
             * 
             * In this example, multiple cases intentionally share the same code block to avoid duplication.
             */
            int month = 3;
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("[>] It's the first quarter of the year.");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("[>] It's the second quarter of the year.");
                    break;
                // ... other quarters
                default:
                    Console.WriteLine("[>] Invalid month.");
                    break;
            }
        }
    }
}
