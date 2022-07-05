using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberListGenerator.Algorithms
{
    public class FisherYatesAlgorithm<T> : IShuffleAlgorithm<T>
    {
        // Shuffle Algorithm based on Fisher-Yates
        /* Sources: https://en.wikipedia.org/wiki/Fisher–Yates_shuffle
         *          https://stackoverflow.com/questions/108819/best-way-to-randomize-an-array-with-net
         */
        public void Shuffle(T[] array)
        {
            var rng = new Random();

            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
