using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.Service;

namespace ThirdTask.Utility.test
{
    internal class ArrayMethods
    {
        private readonly ArraysThings array = new ArraysThings();

        public void Execute()
        {
            InformationPrinter.PrintHeader("Arrays:");

            int[] testArray = MakeData.GenerateArray(10, -20, 50);

            int multiplesOfSeven = array.HowManyMultiplesOfSeven(testArray);
            int positiveCount = array.HowManyPositiveNumbers(testArray);

            InformationPrinter.PrintArrayResult(testArray, multiplesOfSeven, positiveCount);
        }
    }
}
