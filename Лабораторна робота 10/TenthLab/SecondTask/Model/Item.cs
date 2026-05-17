using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Model
{
    internal class Item
    {
        public string name { get; set; }
        public double capacity { get; set; }
        public ItemPriority Priority { get; set; }
        public Item (string Name, double Capacity, ItemPriority priority)
        {
            name = Name;
            capacity = Capacity;
            Priority = priority;
        }
    }
}
