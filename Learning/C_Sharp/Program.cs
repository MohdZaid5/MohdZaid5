/* if you import libraries like (using System;) you can only use it within file.
 * But if you import it as (global using global::System;) you can use it globally throughout the project.
 * 
 * Note that Visual studio projects can do it on its own using <project_name>.GlobalUsing.g.cs
 * You can turn this behaviour off in cs_project-file. by using [ <ImplicitUsings>disable</ImplicitUsings>]
 */
global using global::System;

namespace C_Sharp
{
    class Program
    {
        static void Main()
        {
            // Providing menu and instructions
            Console.WriteLine("[M] Write the Name of Project to Run\n");

            Console.WriteLine("[A] Available Projects:");
            Console.WriteLine("[ ] [0] -> ConsoleAndIO (Input and output handling).");

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

