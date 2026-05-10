using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThirdTask.model
{
    internal struct Item
    {
        public string name { get; set; }
        public ArmorCategory category { get; set; }
        public int strength {  get; set; }
        public decimal price { get; set; }

        public Item(string Name, ArmorCategory Category, int Strength, decimal Price)
        {
            name = Name;
            category = Category;
            strength = Strength;
            price = Price;
        }

        public override string ToString()
        {
            return $"{name},{category},{strength},{price}";
        }
    }
}
