using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberListGenerator.Algorithms
{
    public class FisherYatesAlgorithm<T> : IShuffleAlgorithm<T>
    {
        /// <summary>
        /// Modified Shuffle Algorithm based on Fisher-Yates
        /// </summary>
        /// <param name="list">list of elements to shuffle</param>
        /// <seealso>Sources: https://stackoverflow.com/questions/108819/best-way-to-randomize-an-array-with-net</seealso>
        public void Shuffle(List<T> list)
        {
            if (list == null)
                throw new ArgumentNullException("array");

            var rng = new Random();

            int n = list.Count;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
        }
    }
}
