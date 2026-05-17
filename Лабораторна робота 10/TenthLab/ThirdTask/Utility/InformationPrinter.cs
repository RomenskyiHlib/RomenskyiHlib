using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Utility
{
    internal class InformationPrinter
    {
        public static void PrintHeader(string title)
        {
            Console.WriteLine(title);
        }
        public static void PrintArrayResult(int[] array, int multiplesOfSeven, int positiveCount)
        {
            Console.WriteLine($"Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"The number of numbers divisible by 7: {multiplesOfSeven}");
            Console.WriteLine($"The number of positive numbers: {positiveCount}");
            Console.WriteLine();
        }
        public static void PrintDateResult(DateTime date, bool isProgrammerDay)
        {
            Console.WriteLine($"Data: {date:dd.MM.yyyy} (Day №{date.DayOfYear})");
            Console.WriteLine($"Programmer's Day = {isProgrammerDay}");
            Console.WriteLine();
        }

        public static void PrintTextResult(string originalText, string word, bool isFound)
        {
            Console.WriteLine($"Word \"{word}\" in text = {isFound}");
        }

        public static void PrintInitialText(string text)
        {
            Console.WriteLine($"Start Text: \"{text}\"");
        }
    }
}
