
namespace C_Sharp.Basics
{
    public class ConsoleAndIO
    {
        public static void Example()
        {
            // Output - Printing to Console
            Console.WriteLine("[>] Text (line) can be printed easily to console using Console.WriteLine");

            // Input - Reading from Console
            Console.WriteLine("[>] Input (line) can be taken easily from console using Console.ReadLine");
            Console.Write("[<] Enter Your Name :");
            string? name = Console.ReadLine();

            // Output - Printing the input
            // Simple Concatenation using {+}
            Console.WriteLine("[>] Hello, " + name + " Welcome to C# programming.");
            // Concatenation using <WriteLine> Overload (Remember that index provided in string is used in followed args) ie: 0 will map to first element you pass there
            Console.WriteLine("[>] Hello, {0} Welcome to C# programming.", name);
            // String Interpolation (Similar to f-strings in python)
            Console.WriteLine($"[>] Hello, {name} Welcome to C# programming.");

            // Uncomment code below if needed
            // Wait for user input before closing the console window use ReadKey Method to 
            // Console.WriteLine("Press any key to exit.");
            // Console.ReadKey();

        }

    }
}