using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Model
{
    internal class ItemEventArgs : EventArgs
    {
        public string actionType { get; }
        public Item item { get; }
        public double currentCapacity { get; }

        public ItemEventArgs(string ActionType, Item Item, double CurrentCapacity)
        {
            actionType = ActionType;
            item = Item;
            currentCapacity = CurrentCapacity;
        }
    }
}
