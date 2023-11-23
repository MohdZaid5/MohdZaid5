
namespace C_Sharp.Basics
{
    internal class IterationStatements
    {

        public static void Example()
        {
            /* Loops in C# play a crucial role in repeating specific tasks efficiently. 
             * This code snippet showcases different loop structures, each with comments explaining their syntax and functionality.
             */
            
            /* For Loop:
             *   - Syntax:
             *       for (initialization; condition; increment)
             *       {
             *           // Body
             *       }
             *   - The for loop iterates 10 times, printing the current iteration number.
             */
            for (int i = 0; i < 10; i++)
            {
                // Body of the for loop
                Console.WriteLine($"[>] Currently on iteration number ({i})");
            }

            /* Foreach Loop:
             *   - Iterates over elements in an array or collection.
             *   - Syntax:
             *       foreach (type alias in array)
             *       {
             *           // Body
             *       }
             *   - The foreach loop iterates over an array of names, providing a clear way to access each name.
             */
            string[] names = new string[4] { "Zaid", "Gautam", "Amit", "Prateek" };
            foreach (string name in names)
            {
                // Body of the foreach loop
                Console.WriteLine($"[>] {name} is Present in Class");
            }

            /* While Loop:
             *   - Syntax:
             *       while (condition)
             *       {
             *           // Body
             *       }
             *   - The while loop continues execution as long as the counter is less than 5, printing the current counter value.
             */
            int counter = 0;
            while (counter < 5)
            {
                // Body of the while loop
                Console.WriteLine($"[>] Inside while loop. Counter is {counter}");
                counter++;
            }

            /* Do-While Loop:
             *   - Syntax:
             *       do
             *       {
             *           // Body
             *       } while (condition);
             *   - The do-while loop ensures the body is executed at least once and then continues while 'number' is less than or equal to 5.
             *     It prints the current value of 'number'.
             */
            int number = 1;
            do
            {
                // Body of the do-while loop
                Console.WriteLine($"[>] Inside do-while loop. Number is {number}");
                number++;
            } while (number <= 5);

        }
    }
}
