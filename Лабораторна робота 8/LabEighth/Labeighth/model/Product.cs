using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labeighth.first
{
    internal class Product : IComparable, ICloneable
    {
        public Person supplier { get; set; }
        public string goodsName { get; set; }
        public decimal goodsPrice { get; set; }

        public Product(Person supplier, string goodsName, decimal goodsPrice)
        {
            this.supplier = supplier;
            this.goodsName = goodsName;
            this.goodsPrice = goodsPrice;
        }
        public Product()
        {
            supplier = new Person();
            goodsName = "Nazva";
            goodsPrice = 0m;
        }
        public override string ToString()
        {
            return $"Good: {goodsName}, Good's Price: {goodsPrice}, Supplier: {supplier}";
        }
        public int CompareTo(object obj)
        {
            Product temp = (Product)obj;
            if (goodsPrice > temp.goodsPrice) return 1;
            if (goodsPrice < temp.goodsPrice) return -1;
            return 0;
        }
        public object Clone()
        {
            return new Product((Person)supplier.Clone(),goodsName,goodsPrice);
        }
    }
}
