using labTenth.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Utility.test
{
    internal class PredicateMethods
    {
        private NumbersThings verifier = new NumbersThings();

        public void Execute()
        {
            InformationPrinter.PrintHeader("Predicate:");

            int justNum = MakeData.GetIntNum(1, 100);
            int fibNum = MakeData.GetFibonacciNum();

            InformationPrinter.PrintPredicateResult(justNum, verifier.PrimeNumber, "prime");
            InformationPrinter.PrintPredicateResult(fibNum, verifier.FibonacciNumber, "Fibonacci");
            Console.WriteLine();
        }
    }
}
