
namespace C_Sharp.Basics
{
    public class StatementsAndOperations
    {
        public static void ExampleStatements()
        {
            /* In C#, a statement is a complete and independent unit of execution.
             * It represents a single, standalone instruction that the C# compiler can understand and execute.
             * Statements are the building blocks of a C# program and are used to perform actions or control the logical flow of the program.
             * There are various types of statements in C#.
             * 
             * Here are some common types:
             * 
             * 1. Expression Statements:
             *    - A statement consisting of an expression followed by a semicolon. It performs an action and can include method calls or assignments.
             *
             * 2. Declaration Statements:
             *    - Statements that declare variables or constants. They allocate memory for a variable or constant.
             *
             * 3. Selection Statements:
             *    - Statements used for decision-making and control flow based on conditions. Examples include if, else if, else, and switch statements.
             *
             * 4. Iteration Statements:
             *    - Statements used for repeating a block of code multiple times. Examples include for, while, do-while, and for each statements.
             *
             * 5. Jump Statements:
             *    - Statements used for transferring control within the program. Examples include break, continue, return, and goto statements.
             *
             * 6. Try-Catch Statements:
             *    - Statements used for exception handling. The 'try' block contains code that might throw an exception, and the 'catch' block handles those exceptions.
             */

            // 1. Expression Statement
            int initializedVariable = 5;                                // Assigning a value to a variable is an expression statement

            // 2. Declaration Statement
            int declaredVariable;                                       // Declaring a variable without initializing it
            declaredVariable = initializedVariable;                     // Assigning a value to the declared variable

            // 3. Selection Statement
            // Example: if-else statement
            if (initializedVariable > 0)
            {
                Console.WriteLine("[>] The variable is positive.");
            }
            else
            {
                Console.WriteLine("[>] The variable is non-positive.");
            }

            // 4. Iteration Statement
            // Example: for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"[>] Current value of i: {i}");
            }

            // 5. Jump Statement
            // Example: return statement
            if (declaredVariable < 0)
            {
                Console.WriteLine("[>] Invalid value");
                return; // Exiting the method early using a return statement
            }

            // 6. Try-Catch Statement
            // Example: Handling divide by zero exception
            int divisor = 0;
            int result;
            try
            {
                result = 10 / divisor;                                          // Attempting a division that may throw a DivideByZeroException
                Console.WriteLine($"[>] Result of division: {result}");         // This line won't be executed if an exception occurs
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"[>] Error: {ex.Message}");                  // Handling the DivideByZeroException and displaying an error message
            }
        }

        public static void ExampleOperations() {
            /* Operations, Operators, and Operands:
             * 
             * An operation is a mathematical or logical computation that involves one or more operands.
             * 
             * Operand: Values or variables participating in an operation.
             * Operator: Symbols or keywords representing specific operations between operands.
             * 
             * 1. Addition Operation:
             *    Operand: Two values
             *    Operator: +
             *    Operation: Combining two values
             * 
             * 2. Subtraction Operation:
             *    Operand: Two values
             *    Operator: -
             *    Operation: Finding the difference between two values
             * 
             * 3. Multiplication Operation:
             *    Operand: Two values
             *    Operator: *
             *    Operation: Creating a product of two values
             * 
             * 4. Division Operation:
             *    Operand: Two values
             *    Operator: /
             *    Operation: Dividing one value by another
             * 
             * 5. Modulo Operation:
             *    Operand: Two values
             *    Operator: %
             *    Operation: Obtaining the remainder after division
             * 
             * 6. Logical AND Operation:
             *    Operand: Two boolean values
             *    Operator: &&
             *    Operation: Checking if both boolean values are true
             * 
             * 7. Logical OR Operation:
             *    Operand: Two boolean values
             *    Operator: ||
             *    Operation: Checking if at least one boolean value is true
             * 
             * 8. Logical NOT Operation:
             *    Operand: One boolean value
             *    Operator: !
             *    Operation: Negating the boolean value
             * 
             * 9. Unary Minus Operation:
             *    Operand: One numerical value
             *    Operator: -
             *    Operation: Negating the numerical value
             */

            int sum = 5 + 3;                        // Addition Operation
            int difference = 10 - 2;                // Subtraction Operation
            int product = 4 * 2;                    // Multiplication Operation
            int quotient = 8 / 2;                   // Division Operation
            int remainder = 11 % 3;                 // Modulo Operation
            bool andResult = true && false;         // Logical AND Operation
            bool orResult = true || false;          // Logical OR Operation
            bool notResult = !true;                 // Logical NOT Operation
            int negationResult = -5;                // Unary Minus Operation
            // Displaying results using Console.WriteLine with string interpolation
            Console.WriteLine($"[>] Sum: {sum}");
            Console.WriteLine($"[>] Difference: {difference}");
            Console.WriteLine($"[>] Product: {product}");
            Console.WriteLine($"[>] Quotient: {quotient}");
            Console.WriteLine($"[>] Remainder: {remainder}");
            Console.WriteLine($"[>] Logical AND Result: {andResult}");
            Console.WriteLine($"[>] Logical OR Result: {orResult}");
            Console.WriteLine($"[>] Logical NOT Result: {notResult}");
            Console.WriteLine($"[>] Unary Minus Result: {negationResult}");

        }

    }
}
