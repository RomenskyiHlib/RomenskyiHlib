using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdTask.interfaces;

namespace ThirdTask.model
{
    internal class Armory : IArmory
    {
        public Item[] items;
        public int count;

        public Armory(int size)
        {
            items = new Item[size];
            count = 0;
        }

        public void Create(Item item)
        {
            Add(item);
        }

        public void Add(Item item)
        {
            if (count >= items.Length)
            {
                Console.WriteLine("Full!");
                return;
            }

            items[count++] = item;
        }
        public Item Read(string Name)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].name == Name)
                    return items[i];
            }

            return new Item("Unknown", 0, 0, 0);
        }

        public bool Update(string oldName, Item newItem)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].name.Equals(oldName))
                {
                    items[i] = newItem;
                    return true;
                }
            }

            return false;
        }

        public bool Delete(string Name)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].name.Equals(Name))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }

                    count--; 
                    return true;
                }
            }

            return false;
        }

        public Item[] GetAll()
        {
            Item[] result = new Item[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = items[i];
            }

            return result;
        }
    }
}

