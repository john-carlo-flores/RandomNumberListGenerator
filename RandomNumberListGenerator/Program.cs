using RandomNumberListGenerator.Algorithms;

namespace RandomNumberListGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Sample Usage
            var randomGenerator = new RandomNumberGenerator(new FisherYatesAlgorithm<int>());
            var list = randomGenerator.GenerateRandomList();

            foreach(var item in list)
                Console.WriteLine(item);
        }
    }
}