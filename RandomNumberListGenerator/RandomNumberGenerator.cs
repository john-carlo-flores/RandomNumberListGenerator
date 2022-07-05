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

        /// <summary>
        /// Generates a list of integers based on provided minRange and maxRange inclusive
        /// </summary>
        /// <param name="minRange">minimum number</param>
        /// <param name="maxRange">maximum number</param>
        /// <returns>List of numbers from min to max in randomized order</returns>
        public IEnumerable<int> GenerateRandomList(int minRange = 1, int maxRange = 10000)
        {
            if (maxRange < minRange)
                throw new ArgumentOutOfRangeException("Provided minRange cannot be greater than maxRange");

            var numbers = new List<int>();

            for (var i = 0; i < maxRange; i++)
                numbers.Add(i + minRange);

            algorithm.Shuffle(numbers);

            return numbers;
        }

    }
}