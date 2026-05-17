using SecondTask.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Model
{
    internal class Suitcase
    {
        public string color { get; set; }
        public string manufacturer { get; set; }
        public double capacity { get; set; }
        public Item[] items { get; set; }
        public int MaxItemCount { get; set; }

        public int ItemCount = 0;

        public Suitcase(string color,string manufacturer,double capacity,int itemCount)
        {
            this.color = color;
            this.manufacturer = manufacturer;
            this.capacity = capacity;
            this.MaxItemCount = itemCount;
            items = new Item[itemCount];
        }
        public void Add(Suitcase suitcase, Item item)
        {
            if (suitcase == null) throw new ArgumentNullException(nameof(suitcase));
            if (item == null) throw new ArgumentNullException(nameof(item));

            if (suitcase.ItemCount >= suitcase.items.Length)
                throw new InvalidOperationException("There are no more physical slots left in the case!");

            if (SuitcaseService.CurrentCapacity(suitcase) + item.capacity > suitcase.capacity)
                throw new InvalidOperationException($"Exceeding the capacity of a thing '{item.name}'!");

            suitcase.items[suitcase.ItemCount] = item;
            suitcase.ItemCount++;

            SortByPriority(suitcase);

            OnSuitcaseChanged(new ItemEventArgs("Add", item, SuitcaseService.CurrentCapacity(suitcase)));
        }
        public void Update(Suitcase suitcase, int index, Item newItem)
        {
            if (suitcase == null) throw new ArgumentNullException(nameof(suitcase));
            if (index < 0 || index >= suitcase.MaxItemCount)
                throw new IndexOutOfRangeException("Not existing index");

            if ((SuitcaseService.CurrentCapacity(suitcase) - suitcase.items[index].capacity) + newItem.capacity > suitcase.capacity)
                throw new InvalidOperationException($"Exceeding the capacity when replacing with {newItem.name}!");

            suitcase.items[index] = newItem;

            SortByPriority(suitcase);

            OnSuitcaseChanged(new ItemEventArgs("Update", newItem, SuitcaseService.CurrentCapacity(suitcase)));
        }
        public void Delete(Suitcase suitcase, int index)
        {
            if (suitcase == null) throw new ArgumentNullException(nameof(suitcase));
            if (index < 0 || index >= suitcase.MaxItemCount)
                throw new IndexOutOfRangeException("Not existing index");

            Item removedItem = suitcase.items[index];

            for (int i = index; i < suitcase.MaxItemCount - 1; i++)
            {
                suitcase.items[i] = suitcase.items[i + 1];
            }

            suitcase.items[suitcase.ItemCount - 1] = null;
            suitcase.ItemCount--;

            OnSuitcaseChanged(new ItemEventArgs("Delete", removedItem, SuitcaseService.CurrentCapacity(suitcase)));
        }
        private void SortByPriority(Suitcase suitcase)
        {
            if (suitcase.MaxItemCount <= 1) return;

            Array.Sort(suitcase.items, 0, suitcase.MaxItemCount, Comparer<Item>.Create((x, y) =>
            {
                if (x == null) return 1;
                else if (y == null) return -1;
                else return y.Priority.CompareTo(x.Priority);
            }));
        }
        protected virtual void OnSuitcaseChanged(ItemEventArgs e)
        {
            SuitcaseChanged?.Invoke(this, e);
        }
        public event EventHandler<ItemEventArgs> SuitcaseChanged;
    }
}
