
namespace C_Sharp.Basics
{
    internal class Arrays
    { 
        public static void Example()
        {
            /* Managing Collections in C# */

            // Using individual variables for items
            int numItems = 3;
            string item_1 = "Book";
            string item_2 = "Laptop";
            string item_3 = "Phone";
            // Printing the count and names of individual items
            Console.WriteLine($"[>] I have {numItems} items: {item_1}, {item_2}, {item_3}.");

            // Using an array for items
            string[] itemsArray = { "Book", "Laptop", "Phone" };
            // Printing the count and names of items using an array
            Console.WriteLine($"[>] I have {itemsArray.Length} items: {itemsArray[0]}, {itemsArray[1]}, {itemsArray[2]}.");

            // Using a separate array with manual assignment for items
            string[] itemsManual = new string[3];
            itemsManual[0] = "Book";
            itemsManual[1] = "Laptop";
            itemsManual[2] = "Phone";
            // Printing the count and names of items using a manually assigned array
            Console.WriteLine($"[>] I have {itemsManual.Length} items: {itemsManual[0]}, {itemsManual[1]}, {itemsManual[2]}.");

            // Using an array for prices
            double[] prices = new double[3] { 29.99, 999.99, 699.99 };
            // Printing the prices of items using an array
            Console.WriteLine($"[>] Prices of items: ${prices[0]}, ${prices[1]}, ${prices[2]}.");

            // Additional Example: Using an array for cities
            string[] cities = { "New York", "Paris", "Tokyo" };
            // Printing my favorite cities using an array
            Console.WriteLine($"[>] My favorite cities: {cities[0]}, {cities[1]}, {cities[2]}.");

            // Additional Example: Using an array for ages
            int[] ages = { 25, 30, 22 };
            // Printing ages of individuals using an array
            Console.WriteLine($"[>] Ages of individuals: {ages[0]}, {ages[1]}, {ages[2]}.");

            // Additional Example: Using an array for test scores
            float[] testScores = new float[4] { 89.5f, 92.0f, 78.2f, 95.8f };
            // Printing test scores using an array
            Console.WriteLine($"[>] Test scores: {testScores[0]}, {testScores[1]}, {testScores[2]}, {testScores[3]}.");

        }
    }
}
