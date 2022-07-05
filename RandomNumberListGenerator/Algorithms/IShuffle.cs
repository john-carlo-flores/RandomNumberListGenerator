﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberListGenerator.Algorithms
{
    public interface IShuffleAlgorithm<T>
    {
        void Shuffle(List<T> array);
    }
}
