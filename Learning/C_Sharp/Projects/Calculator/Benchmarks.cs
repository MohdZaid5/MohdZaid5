
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Calculator
{

    // Benchmark class for testing the performance of factorization algorithms
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class FactorAlgorithmBenchmarks
    {
        private readonly Random random = new();

        // Randomly generated values for benchmarking
        private readonly int SmallNumber;
        private readonly int MediumNumber;
        private readonly int LargeNumber;
        private readonly int VeryLargeNumber;

        // Constructor to initialize random values
        public FactorAlgorithmBenchmarks()
        {
            SmallNumber = random.Next(1, 100);
            MediumNumber = random.Next(100, 10000);
            LargeNumber = random.Next(10000, 1000000);
            VeryLargeNumber = random.Next(1000000, int.MaxValue);
        }

        // Benchmark methods for SimpleFactorAlgorithm with different input sizes
        [Benchmark]
        public void Core_SimpleFactorAlgorithm_SmallNumber_Benchmark()
        {
            Core.SimpleFactorAlgorithm(SmallNumber);
        }

        [Benchmark]
        public void Core_SimpleFactorAlgorithm_MediumNumber_Benchmark()
        {
            Core.SimpleFactorAlgorithm(MediumNumber);
        }

        [Benchmark]
        public void Core_SimpleFactorAlgorithm_LargeNumber_Benchmark()
        {
            Core.SimpleFactorAlgorithm(LargeNumber);
        }

        [Benchmark]
        public void Core_SimpleFactorAlgorithm_VeryLargeNumber_Benchmark()
        {
            Core.SimpleFactorAlgorithm(VeryLargeNumber);
        }

        // Benchmark methods for OptimizedFactorAlgorithm with different input sizes
        [Benchmark]
        public void Core_OptimizedFactorAlgorithm_SmallNumber_Benchmark()
        {
            Core.OptimizedFactorAlgorithm(SmallNumber);
        }

        [Benchmark]
        public void Core_OptimizedFactorAlgorithm_MediumNumber_Benchmark()
        {
            Core.OptimizedFactorAlgorithm(MediumNumber);
        }

        [Benchmark]
        public void Core_OptimizedFactorAlgorithm_LargeNumber_Benchmark()
        {
            Core.OptimizedFactorAlgorithm(LargeNumber);
        }

        [Benchmark]
        public void Core_OptimizedFactorAlgorithm_VeryLargeNumber_Benchmark()
        {
            Core.OptimizedFactorAlgorithm(VeryLargeNumber);
        }
    }
}