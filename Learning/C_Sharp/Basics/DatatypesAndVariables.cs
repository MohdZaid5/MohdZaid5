
namespace C_Sharp.Basics
{
    public class DatatypesAndVariables
    {

        public static void Example()
        {
            /* You can declare a variable using any of two syntax.
             *  1: <datatype> <variable_name> = <value>;
             *  2: <datatype> <variable_name>;
             *  
             *  first method creates a variable and assigns a value immediately.
             *  whereas in second method you just make a variable (allocate some space for data to come) andd assign it later.
             */

            // Direct assignment.
            int variable = 0;
            Console.WriteLine($"[>] We have assigned value {variable} to variable.");

            // Allocation and Assigning value to the allocated variable (allocated space).
            int unassigned;     // Allocation
            unassigned = 0;     // Assignment
            Console.WriteLine($"[>] We have assigned value {unassigned} to unassigned.");


            /* There are some Datatypes in cSharp which signifies the amount of allocated space a variable takes and methods available to the datatype,
             * Some of them are:
             *  -> short    : (2 bytes) : It stores smaller numbers.
             *  -> int      : (4 bytes) : As the name suggest it stores integer values.
             *  -> long     : (8 bytes) : Stores large integer values.
             *  -> float     : (4 bytes) : Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits.
             *  -> double   : (8 bytes) : A double is a number with decimals. (similar to float but more precise) 15 decimal digits.
             *  -> bool	    : (1 bit  )	: Stores true or false values.
             *  -> char	    : (2 bytes)	: Stores a single character/letter, surrounded by single quotes.
             *  -> string	: (2 bytes) {per character} : Stores a sequence of characters, surrounded by double quotes
             *  
             *  Naming Conventions:
             *  -> in C# mainly use camel casing (thisIsMyVariable).
             *  
             *  Special keywords:
             *  -> const    : A variable which cannot be changed, keyword const is used to specify that.
             *  -> s        : specifies if variable is signed.
             *              \>a signed byte will have values from -128 to 127.
             *              \>a normal byte will have values form 0 to 255.
             *  -> u        : specifies if variable is unsigned.
             *              \>a unsigned int will have values from 0 to 4B.
             *              \>a normal int will have values form -2B to 2B.
             */

            // Example of each data type
            short myShortNumber = -10000;               // A short number within (2^15) as each byte stores 2^8 and one bit for sign.
            ushort myUnsignedShortNumber = 10000;       // An unsigned short number within (2^16) as each byte stores 2^8 only positive.
            int myInteger = -123456789;                 // Integer value, can store a wide range of whole numbers.
            uint myUnsignedInteger = 123456789;         // Unsigned integer, only stores positive whole numbers.
            float myFloatNumber = 3.14f;                 // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits.
            double myDoubleNumber = 3.141592653589793;  // A double is a number with decimals. More precise, stores 15 decimal digits.
            bool isTrue = true;                         // Boolean, stores true or false values.
            char myChar = 'A';                          // Stores a single character/letter, surrounded by single quotes.
            string myString = "Hello, World!";          // Stores a sequence of characters, surrounded by double quotes.
            
            // Printing information about each variable to the console with string interpolation
            Console.WriteLine($"[>] Short Number: {myShortNumber} - A short integer within (2^15) range.");
            Console.WriteLine($"[>] Unsigned Short Number: {myUnsignedShortNumber} - An unsigned short integer within (2^16) range.");
            Console.WriteLine($"[>] Integer: {myInteger} - Represents a wide range of whole numbers.");
            Console.WriteLine($"[>] Unsigned Integer: {myUnsignedInteger} - Represents only positive whole numbers.");
            Console.WriteLine($"[>] Float Number: {myFloatNumber} - Stores fractional numbers with 6-7 decimal digits of precision.");
            Console.WriteLine($"[>] Double Number: {myDoubleNumber} - A more precise decimal number with 15 decimal digits of precision.");
            Console.WriteLine($"[>] Boolean: {isTrue} - Represents a true or false value.");
            Console.WriteLine($"[>] Character: {myChar} - Represents a single character or letter.");
            Console.WriteLine($"[>] String: {myString} - Represents a sequence of characters.");

            // Gravitational constant (example value, actual value is approximately 6.67430 × 10^-11 m^3 kg^-1 s^-2)
            const double gravitationalConstant = 6.67430e-11;
            // Attempting to change the value of a const variable will result in a compilation error
            // Uncommenting the line below will result in a compilation error
            // gravitationalConstant = 100.00;
            Console.WriteLine($"[>] Constant Number: {gravitationalConstant} - A variable that cannot be changed.");
        }

    }
}
