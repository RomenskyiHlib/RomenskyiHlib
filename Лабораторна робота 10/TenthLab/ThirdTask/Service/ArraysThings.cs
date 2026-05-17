using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Service
{
    internal class ArraysThings
    {
        public Func<int[], int> HowManyMultiplesOfSeven =>
            array => array.Count(x => x % 7 == 0 && x != 0);

        public Func<int[], int> HowManyPositiveNumbers =>
            array => array.Count(x => x > 0);
    }
}
