
namespace C_Sharp
{
    class Program
    {
        static void Main()
        {
            // Providing menue and instructions
            Console.WriteLine("[M] Write the Name of Project to Run\n");

            Console.WriteLine("[A] Available Projects:");
            Console.WriteLine("[ ] [0] -> ConsoleAndIO (Input and output handeling).");

            // Take input from user
            Console.Write("[Y] Your Choice:");
            string? user_input = Console.ReadLine();

            int ProjectToRun = 0;
            if (user_input != null)
            {
                ProjectToRun = int.Parse( user_input );
            }

            if ( ProjectToRun == 0)
            {
                Console.WriteLine("\n[=] Running ConsoleAndIO.Example().");
                Basics.ConsoleAndIO.Example();
            }
            else
            {
                Console.WriteLine($"[!] Invalid Choice {ProjectToRun} is not valid Project.");
            }

            Console.WriteLine($"[=] EOP End of project.\n");
            Console.WriteLine($"[E] Press any key to Exit.");
            // Wait Before Ending
            Console.ReadKey();
        }
    }
}

