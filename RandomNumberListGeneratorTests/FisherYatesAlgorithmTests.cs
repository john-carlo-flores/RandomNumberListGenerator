using NUnit.Framework;
using RandomNumberListGenerator.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberListGenerator.UnitTests
{
    [TestFixture]
    public class FisherYatesAlgorithmTests
    {
        private FisherYatesAlgorithm<int> algorithm;

        [SetUp]
        public void SetUp()
        {
            algorithm = new FisherYatesAlgorithm<int>();
        }

        [Test]
        public void Shuffle_NullArrayProvided_ThrowsArgumentNullException()
        {
            int[] array = null;

            Assert.That(() => algorithm.Shuffle(array), Throws.ArgumentNullException);
        }

        [Test]
        public void Shuffle_ValidArrayProvided_ReturnsUniqueArrayList()
        {
            int[] array1 = new int[] {1, 2, 3, 4, 5};
            int[] array2 = new int[] {1, 2, 3, 4, 5};

            algorithm.Shuffle(array1);
            algorithm.Shuffle(array2);

            Assert.That(array1.Length, Is.EqualTo(array2.Length));
            Assert.IsFalse(array1.SequenceEqual(array2));
        }
    }
}
