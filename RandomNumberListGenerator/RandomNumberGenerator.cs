using RandomNumberListGenerator.Algorithms;

namespace RandomNumberListGenerator
{
    public class RandomNumberGenerator
    {
        private readonly IShuffleAlgorithm<int> algorithm;

        // Use dependency injection to allow usage of other Algorithms and provide more testability
        public RandomNumberGenerator(IShuffleAlgorithm<int> algorithm)
        {
            this.algorithm = algorithm;
        }

        public IEnumerable<int> GenerateRandomList(int minRange = 1, int maxRange = 10000)
        {
            // Check for invalid range 
            if (maxRange < minRange)
                throw new ArgumentOutOfRangeException("Provided minRange cannot be greater than maxRange");

            // Create numbers list
            var numbers = new int[maxRange - minRange + 1];

            // Populate with numbers between minRange and maxRange
            for (var i = 0; i < maxRange; i++)
                numbers[i] = i + minRange;

            // Shuffle based on injected algorithm
            algorithm.Shuffle(numbers);

            return numbers;
        }

    }
}