
namespace Calculator.Test
{
    public class TestAdd
    {
        [Theory]
        [InlineData( 20, 20, 40 )]      // Tests both positive input
        [InlineData( 00, 00, 00 )]      // Tests both zero input
        [InlineData( 20, -5, 15 )]      // Tests negative and positive input
        [InlineData( -0, -5, -5 )]      // Tests both negative input
        public void Core_Add_ReturnsInt( int num1, int num2, int expected )
        {
            var result = Calculator.Core.Add(num1, num2);
            result.Should().Be( expected );
        }
        
        [Theory]
        [InlineData( 0.2f, 0.2f, 0.4f )]// Tests both positive and decimal input
        [InlineData( 0.0f, 0.0f, 0.0f )]// Tests both zero floating point input
        [InlineData(  20f,  30f,  50f )]// Tests both positive and decimal input
        [InlineData( 0.2f, -.5f, -.3f )]// Tests positive and negative input
        [InlineData(  20f, -30f, -10f )]// Tests positive and negative input
        [InlineData( -20f, -30f, -50f )]// Tests positive and negative input
        [InlineData( -.2f, -.3f, -.5f )]// Tests positive and negative input
        public void Core_Add_ReturnsFloat( float num1, float num2, float expected )
        {
            var result = Calculator.Core.Add(num1, num2);
            result.Should().Be( expected );
        }
        
        [Theory]
        [InlineData(  0.2,  0.2,  0.4 )]// Tests both positive and double input
        [InlineData(  0.0,  0.0,  0.0 )]// Tests both zero double point input
        [InlineData( 20.0, 30.0, 50.0 )]// Tests both positive and double input
        [InlineData(  0.2, -0.5, -0.3 )]// Tests positive and negative input
        [InlineData(  2.0, -3.0, -1.0 )]// Tests positive and negative input
        [InlineData( -2.0, -3.0, -5.0 )]// Tests positive and negative input
        [InlineData( -0.2, -0.3, -0.5 )]// Tests positive and negative input
        public void Core_Add_ReturnsDouble( double num1, double num2, double expected )
        {
            var result = Calculator.Core.Add(num1, num2);
            result.Should().Be( expected );
        }

    }

    public class TestSub { 

        [Theory]
        [InlineData( 20, 10,  10)]      // Tests positive input
        [InlineData( 00, 00,  00)]      // Tests zero input
        [InlineData( 20, -5,  25)]      // Tests negative and positive input
        [InlineData(-20, -5, -15)]      // Tests both negative input
        public void Core_Sub_ReturnsInt(int num1, int num2, int expected)
        {
            var result = Calculator.Core.Sub(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData( 0.2f,  0.1f, 0.1f)]  // Tests positive and decimal input
        [InlineData( 0.0f,  0.0f, 0.0f)]  // Tests zero floating point input
        [InlineData( 0.2f, -0.5f, 0.7f)]  // Tests positive and negative input
        [InlineData( 2.0f, -3.0f, 5.0f)]  // Tests positive and negative input
        [InlineData(-2.0f, -3.0f, 1.0f)]  // Tests positive and negative input
        public void Core_Sub_ReturnsFloat(float num1, float num2, float expected)
        {
            var result = Calculator.Core.Sub(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData( 0.2,  0.1, 0.1)]     // Tests positive and double input
        [InlineData( 0.0,  0.0, 0.0)]     // Tests zero double point input
        [InlineData( 0.2, -0.5, 0.7)]     // Tests positive and negative input
        [InlineData( 2.0, -3.0, 5.0)]     // Tests positive and negative input
        [InlineData(-2.0, -3.0, 1.0)]     // Tests positive and negative input
        public void Core_Sub_ReturnsDouble(double num1, double num2, double expected)
        {
            var result = Calculator.Core.Sub(num1, num2);
            result.Should().Be(expected);
        }
    }

    public class TestMul 
    { 
        [Theory]
        [InlineData( 5,  2, 10)]           // Tests positive input
        [InlineData( 0,  5,  0)]           // Tests zero input
        [InlineData( 4, -2, -8)]           // Tests negative and positive input
        [InlineData(-4, -2,  8)]           // Tests both negative input
        public void Core_Mul_ReturnsInt(int num1, int num2, int expected)
        {
            var result = Calculator.Core.Mul(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData( 0.5f,  2.0f,  1.0f)]   // Tests positive and decimal input
        [InlineData( 0.0f,  5.0f,  0.0f)]   // Tests zero floating point input
        [InlineData( 2.0f, -0.5f, -1.0f)]   // Tests positive and negative input
        [InlineData( 2.0f, -3.0f, -6.0f)]   // Tests positive and negative input
        [InlineData(-2.0f, -3.0f,  6.0f)]   // Tests positive and negative input
        public void Core_Mul_ReturnsFloat(float num1, float num2, float expected)
        {
            var result = Calculator.Core.Mul(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData( 0.5,  2.0,  1.0)]       // Tests positive and double input
        [InlineData( 0.0,  5.0,  0.0)]       // Tests zero double point input
        [InlineData( 2.0, -0.5, -1.0)]       // Tests positive and negative input
        [InlineData( 2.0, -3.0, -6.0)]       // Tests positive and negative input
        [InlineData(-2.0, -3.0,  6.0)]       // Tests positive and negative input
        public void Core_Mul_ReturnsDouble(double num1, double num2, double expected)
        {
            var result = Calculator.Core.Mul(num1, num2);
            result.Should().Be(expected);
        }
    }

    public class TestDiv
    {
        [Theory]
        [InlineData( 20, 2, 10.0f)]          // Tests positive input
        [InlineData(  0, 5,  0.0f)]          // Tests zero numerator
        [InlineData(-15, 3, -5.0f)]          // Tests negative numerator and positive denominator
        [InlineData(-10, -2, 5.0f)]          // Tests negative numerator and negative denominator
        public void Core_Div_ReturnsFloat_ForInt(int num1, int num2, float expected)
        {
            var result = Calculator.Core.Div(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(  5.0f,  2.0f,  2.5f)]     // Tests positive input
        [InlineData(  0.0f,  5.0f,  0.0f)]     // Tests zero numerator
        [InlineData(-15.0f,  3.0f, -5.0f)]     // Tests negative numerator and positive denominator
        [InlineData(-10.0f, -2.0f,  5.0f)]     // Tests negative numerator and negative denominator
        public void Core_Div_ReturnsFloat(float num1, float num2, float expected)
        {
            var result = Calculator.Core.Div(num1, num2);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(  5.0,  2.0,  2.5)]        // Tests positive input
        [InlineData(  0.0,  5.0,  0.0)]        // Tests zero numerator
        [InlineData(-15.0,  3.0, -5.0)]        // Tests negative numerator and positive denominator
        [InlineData(-10.0, -2.0,  5.0)]        // Tests negative numerator and negative denominator
        public void Core_Div_ReturnsDouble(double num1, double num2, double expected)
        {
            var result = Calculator.Core.Div(num1, num2);
            result.Should().Be(expected);
        }

        [Fact]
        public void Core_DivFloat_DivideByZero_ThrowsException()
        {
            float numerator = 10.0f;
            float denominator = 0.0f;
            Assert.Throws<ArgumentException>(() => Calculator.Core.Div(numerator, denominator));
        }

        [Fact]
        public void Core_DivDouble_DivideByZero_ThrowsException()
        {
            double numerator = 10.0;
            double denominator = 0.0;
            Assert.Throws<ArgumentException>(() => Calculator.Core.Div(numerator, denominator));
        }

        [Fact]
        public void Core_DivInt_DivideByZero_ThrowsException()
        {
            int numerator = 10;
            int denominator = 0;
            Assert.Throws<ArgumentException>(() => Calculator.Core.Div(numerator, denominator));
        }
    }

    public class TestFactorAlgorithms
    {
        [Theory]
        [InlineData( 1, new[] { 1 })]           // Tests the smallest prime number
        [InlineData( 2, new[] { 1, 2 })]        // Tests the smallest even prime number
        [InlineData( 3, new[] { 1, 3 })]        // Tests the smallest odd prime number
        [InlineData( 4, new[] { 1, 2, 4 })]     // Tests a composite number
        [InlineData( 7, new[] { 1, 7 })]        // Tests a prime number
        [InlineData(10, new[] { 1, 2, 5, 10 })] // Tests a composite number
        [InlineData(13, new[] { 1, 13 })]       // Tests a prime number
        [InlineData(25, new[] { 1, 5, 25 })]    // Tests a composite number
        public void Core_SimpleFactorAlgorithm_ReturnsFactors(int number, int[] expectedFactors)
        {
            var result = Calculator.Core.SimpleFactorAlgorithm(number);
            result.Should().BeEquivalentTo(expectedFactors);
        }

        [Theory]
        [InlineData(1, new[] { 1 })]            // Tests the smallest prime number
        [InlineData(2, new[] { 1, 2 })]         // Tests the smallest even prime number
        [InlineData(3, new[] { 1, 3 })]         // Tests the smallest odd prime number
        [InlineData(4, new[] { 1, 2, 4 })]      // Tests a composite number
        [InlineData(7, new[] { 1, 7 })]         // Tests a prime number
        [InlineData(10, new[] { 1, 2, 5, 10 })] // Tests a composite number
        [InlineData(13, new[] { 1, 13 })]       // Tests a prime number
        [InlineData(25, new[] { 1, 5, 25 })]    // Tests a composite number
        public void Core_OptimizedFactorAlgorithm_ReturnsFactors(int number, int[] expectedFactors)
        {
            var result = Calculator.Core.OptimizedFactorAlgorithm(number);
            result.Should().BeEquivalentTo(expectedFactors);
        }
    }
}
