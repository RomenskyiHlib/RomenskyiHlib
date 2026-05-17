using SecondTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Utility
{
    internal class MakeData
    {
        private static Random random = new Random();


        private static (string Name, double Cap, ItemPriority Priority)[] ItemPool =
        {
            ("Laptop",    4.0, ItemPriority.High),
            ("First-aid kit",    2.0, ItemPriority.High),
            ("Powerbank",  1.0, ItemPriority.Medium),
            ("Jacket",     8.0, ItemPriority.Medium),
            ("Sneakers",   6.0, ItemPriority.Low),
            ("towel",     5.0, ItemPriority.Low)
        };

        public static Item GetRandomItem()
        {

            var template = ItemPool[random.Next(ItemPool.Length)];

            return new Item(template.Name, template.Cap, template.Priority);
        }
    }
}
