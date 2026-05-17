using SecondTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Service
{
    internal class SuitcaseService
    {
        public static double CurrentCapacity(Suitcase suitcase)
        {
            double total = 0;
            for (int i = 0; i < suitcase.MaxItemCount; i++)
            {
                if (suitcase.items[i] != null)
                {
                    total += suitcase.items[i].capacity;
                }
            }
            return total;
        }
        public static void InitializeSuitcase(Suitcase suitcase, string Color, string Manufacturer, double MaxCapacity, int maxSlots)
        {
            if (suitcase == null) throw new ArgumentNullException(nameof(suitcase));

            suitcase.color = Color;
            suitcase.manufacturer = Manufacturer;
            suitcase.capacity = MaxCapacity;
            suitcase.items = new Item[maxSlots];
            suitcase.MaxItemCount = 0;
        }
    }
}
