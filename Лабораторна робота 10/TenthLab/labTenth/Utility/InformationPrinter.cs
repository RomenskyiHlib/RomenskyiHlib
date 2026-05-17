using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTenth.Utility
{
    internal class InformationPrinter
    {
        public static void PrintHeader(string title)
        {
            Console.WriteLine(title);
        }
        public static void PrintPredicateResult(int number, Predicate<int> check, string checkName)
        {
            Console.WriteLine($"Is the number {number} {checkName}? = {check(number)}");
        }

        public static void PrintAreaResult(string figureName, string parameters, double area)
        {
            Console.WriteLine($"Area {figureName} ({parameters}) = {area}");
        }
    }
}
