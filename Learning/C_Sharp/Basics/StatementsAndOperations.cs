
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
             */
            // Some basic Operators
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


            /* Increment and Decrement Operators:
             * 
             * The increment operator '++' adds one to the variable. When used as postfix (x++), it returns the current value of x and then increments it.
             * When used as prefix (++x), it increments x first and then returns the updated value.
             * 
             * The decrement operator '--' subtracts one from the variable. When used as postfix (x--), it returns the current value of x and then decrements it.
             * When used as prefix (--x), it decrements x first and then returns the updated value.
             */
            int a = 5;
            int b = 3;
            // Incrementing the value of 'a' using postfix and prefix notation
            Console.WriteLine($"[>] Initial value of 'a': {a}");
            Console.WriteLine($"[>] After a++, current value of 'a': {a++}, new value of 'a': {a}");
            Console.WriteLine($"[>] After ++a, updated value of 'a': {++a}");
            // Decrementing the value of 'b' using postfix and prefix notation
            Console.WriteLine($"[>] Initial value of 'b': {b}");
            Console.WriteLine($"[>] After b--, current value of 'b': {b--}, new value of 'b': {b}");
            Console.WriteLine($"[>] After --b, updated value of 'b': {--b}");


            /* Comparison Operators:
             * 
             * Comparison operators are used to compare two values. They return a Boolean result indicating whether the comparison is true or false.
             * 
             * Common comparison operators:
             *   - Equal to (==): Checks if two values are equal.
             *   - Not equal to (!=): Checks if two values are not equal.
             *   - Greater than (>): Checks if the left value is greater than the right value.
             *   - Less than (<): Checks if the left value is less than the right value.
             *   - Greater than or equal to (>=): Checks if the left value is greater than or equal to the right value.
             *   - Less than or equal to (<=): Checks if the left value is less than or equal to the right value.
             */
            int x = 10;
            int y = 5;
            // Examples comparison operators
            Console.WriteLine($"[>] Is x equal to y? {x == y}");                    // Checks if x is equal to y (Output: False)
            Console.WriteLine($"[>] Is x not equal to y? {x != y}");                // Checks if x is not equal to y (Output: True)
            Console.WriteLine($"[>] Is x greater than y? {x > y}");                 // Checks if x is greater than y (Output: True)
            Console.WriteLine($"[>] Is x less than y? {x < y}");                    // Checks if x is less than y (Output: False)
            Console.WriteLine($"[>] Is x greater than or equal to y? {x >= y}");    // Checks if x is greater than or equal to y (Output: True)
            Console.WriteLine($"[>] Is x less than or equal to y? {x <= y}");       // Checks if x is less than or equal to y (Output: False)


            /* Assignment Operators:
             * 
             * Assignment operators are used to assign values to variables and perform operations at the same time.
             * 
             * Common assignment operators:
             *   - Assignment (=): Assigns the value on the right to the variable on the left.
             *   - Addition and Assignment (+=): Adds the value on the right to the variable on the left and assigns the result to the variable on the left.
             *   - Subtraction and Assignment (-=): Subtracts the value on the right from the variable on the left and assigns the result to the variable on the left.
             *   - Multiplication and Assignment (*=): Multiplies the variable on the left by the value on the right and assigns the result to the variable on the left.
             *   - Division and Assignment (/=): Divides the variable on the left by the value on the right and assigns the result to the variable on the left.
             *   - Modulus and Assignment (%=): Computes the remainder of the variable on the left divided by the value on the right and assigns the result to the variable on the left.
             */
            int value1;
            int value2 = 5;
            // Examples assignment operators
            Console.WriteLine($"[>] Assignment (=): {value1 = value2}");  // Assigns the value of 'value2' to 'value1' and returns the new value of 'value1'
            Console.WriteLine($"[>] Addition and Assignment (+=): {value1 += value2}");  // Adds 'value2' to 'value1' and assigns the result to 'value1'
            Console.WriteLine($"[>] Subtraction and Assignment (-=): {value1 -= value2}");  // Subtracts 'value2' from 'value1' and assigns the result to 'value1'
            Console.WriteLine($"[>] Multiplication and Assignment (*=): {value1 *= value2}");  // Multiplies 'value1' by 'value2' and assigns the result to 'value1'
            Console.WriteLine($"[>] Division and Assignment (/=): {value1 /= value2}");  // Divides 'value1' by 'value2' and assigns the result to 'value1'
            Console.WriteLine($"[>] Modulus and Assignment (%=): {value1 %= value2}");  // Computes the remainder of 'value1' divided by 'value2' and assigns the result to 'value1'

        }

    }
}
