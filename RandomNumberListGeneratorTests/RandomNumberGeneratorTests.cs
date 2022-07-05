using NUnit.Framework;
using RandomNumberListGenerator.Algorithms;

namespace RandomNumberListGenerator.UnitTests
{
    [TestFixture]
    public class RandomNumberGeneratorTests
    {
        private RandomNumberGenerator _randomNumberGenerator;

        [SetUp]
        public void SetUp()
        {
            _randomNumberGenerator = new RandomNumberGenerator(new FisherYatesAlgorithm<int>());
        }

        [Test]
        public void GenerateRandomList_MinRangeIsGreaterThanMaxRangeProvided_ThrowsArgumentOutOfRangeException()
        {
            int minRange = 2;
            int maxRange = 1;

            Assert.That(() => _randomNumberGenerator.GenerateRandomList(minRange, maxRange), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GenerateRandomList_ValidMinMaxRangeProvided_MixMaxRangeProvidedMustBeInclusive()
        {
            int minRange = 1;
            int maxRange = 5;

            var list = _randomNumberGenerator.GenerateRandomList(minRange, maxRange);

            Assert.That(list.Contains(minRange));
            Assert.That(list.Contains(maxRange));
        }

        [Test]
        public void GenerateRandomList_ValidMinMaxRangeProvided_ShouldHaveListLengthFromMinToMaxInclusive()
        {
            int minRange = 1;
            int maxRange = 5;

            var list = _randomNumberGenerator.GenerateRandomList(minRange, maxRange);

            Assert.That(list.Count, Is.EqualTo(5));
        }

        [Test]
        public void GenerateRandomList_ValidMinMaxRangeProvided_ShouldReturnUniqueListOfNumbers()
        {
            int minRange = 1;
            int maxRange = 5;

            var list = _randomNumberGenerator.GenerateRandomList(minRange, maxRange);

            Assert.That(list.Distinct().Count(), Is.EqualTo(list.Count()));
        }

        [Test]
        public void GenerateRandomList_ValidMinMaxRangeProvided_ShouldHaveAUniqueOrderEachTimeAListIsGenerated()
        {
            int minRange = 1;
            int maxRange = 5;

            var list1 = _randomNumberGenerator.GenerateRandomList(minRange, maxRange);
            var list2 = _randomNumberGenerator.GenerateRandomList(minRange, maxRange);

            Assert.That(list1.Count(), Is.EqualTo(list2.Count()));
            Assert.IsFalse(list1.SequenceEqual(list2));
        }

        [Test]
        public void GenerateRandomList_NoArgumentsProvided_ShouldReturnListFrom1To10000()
        {
            var list = _randomNumberGenerator.GenerateRandomList();

            Assert.That(list.Contains(1));
            Assert.That(list.Contains(10000));
            Assert.That(list.Count(), Is.EqualTo(10000));
        }
    }
}