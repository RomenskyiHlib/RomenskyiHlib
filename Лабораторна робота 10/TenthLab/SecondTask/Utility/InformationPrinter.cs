using SecondTask.Model;
using SecondTask.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Utility
{
    internal class InformationPrinter
    {
        public static void PrintHeader(string title)
        {
            Console.WriteLine(title);
        }

        public static void PrintSuitcaseState(Suitcase suitcase, SuitcaseService service)
        {
            Console.WriteLine($"Suitcase [{suitcase.manufacturer}],[{suitcase.color}] | Max capacity: {suitcase.capacity} | Slots: {suitcase.MaxItemCount}");
            Console.WriteLine("Current capacity");
            if (suitcase.MaxItemCount == 0) Console.WriteLine("Case is empty");

            for (int i = 0; i < suitcase.MaxItemCount; i++)
            {
                Item item = suitcase.items[i];

                if (item == null) continue;

                Console.WriteLine($" Slot [{i}]: {item.name} | Capacity: {item.capacity}| Priority: {item.Priority}");
            }

            Console.WriteLine($"Total occupied capacity: {SuitcaseService.CurrentCapacity(suitcase)} / {suitcase.capacity}");
            Console.WriteLine();
        }

        public static void OnSuitcaseChangedListener(object sender, ItemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[SLYKHACH]: {e.actionType}, {e.item.name} (priority: {e.item.Priority}). current capacity: {e.currentCapacity}");
            Console.ResetColor();
        }

        public static void PrintException(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[EXCEPTION]: {message}");
            Console.ResetColor();
        }
    }
}
