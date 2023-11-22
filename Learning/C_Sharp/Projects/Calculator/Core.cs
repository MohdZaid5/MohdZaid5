

namespace Calculator
{
    public class Core
    {

        public static int Add(int number1, int number2) => number1 + number2;
        public static long Add(long number1, long number2) => number1 + number2;
        public static float Add(float number1, float number2) => number1 + number2;
        public static double Add(double number1, double number2) => number1 + number2;


        public static int Sub(int number1, int number2) => number1 - number2;
        public static long Sub(long number1, long number2) => number1 - number2;
        public static float Sub(float number1, float number2) => number1 - number2;
        public static double Sub(double number1, double number2) => number1 - number2;


        public static int Mul(int number1, int number2) => number1 * number2;
        public static long Mul(long number1, long number2) => number1 * number2;
        public static float Mul(float number1, float number2) => number1 * number2;
        public static double Mul(double number1, double number2) => number1 * number2;


        public static float Div(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return number1 / number2;
        }
        public static float Div(float number1, float number2)
        {
            if (number2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return number1 / number2;
        }
        public static double Div(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return number1 / number2;
        }

    }
}
