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
            List<int> array = null;

            Assert.That(() => algorithm.Shuffle(array), Throws.ArgumentNullException);
        }

        [Test]
        public void Shuffle_ValidArrayProvided_ReturnsUniqueArrayList()
        {
            List<int> list1 = new List<int> {1, 2, 3, 4, 5};
            List<int> list2 = new List<int> {1, 2, 3, 4, 5};

            algorithm.Shuffle(list1);
            algorithm.Shuffle(list2);

            Assert.That(list1.Count, Is.EqualTo(list2.Count));
            Assert.IsFalse(list1.SequenceEqual(list2));
        }
    }
}
