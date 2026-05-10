using Labeighth.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labeighth.first
{
    enum ProductCategory
    {
        OfficeEquipment, Software, OfficeSupplies, Food, Clothes, ForEducation, Other
    }
    internal class Shop : IFileContainer<Product>, IEnumerable
    {
        private string shopName;
        private ProductCategory category;
        private DateTime foundingShop;
        private double totalCost;
        private Product[] products;
        private bool isDataSaved = true;

        public Shop(string shopName, ProductCategory category, DateTime foundingShop, Product[] products)
        {
            this.shopName = shopName;
            this.category = category;
            this.foundingShop = foundingShop;
            this.products = products;
        }
        public Shop()
        {
            shopName = "Mahazin";
            category = ProductCategory.Other;
            foundingShop = new DateTime(2000, 08, 20);
            totalCost = 0.0;
            products = new Product[0];

        }
        public override string ToString()
        {
            string str = $"Shop Name: {shopName}, Good's Category: {category}, The founding of the Shop: {foundingShop}, Total Cost: {totalCost}, Goods = ";
            foreach (var product in products)
            {
                str += product.ToString();
            }
            return str;
        }
        public string ToShortString()
        {
            return $"Shop Name: {shopName}, Good's Category: {category}, The founding of the Shop: {foundingShop}, Total Cost: {totalCostCalc}";
        }
        public string ShopName
        {
            get { return shopName; }
            set
            {
                if (value != null) shopName = value;
                else throw new ArgumentNullException();
            }
        }
        public ProductCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        public DateTime FoundingShop
        {
            get { return foundingShop; }
            set
            {
                if (value < DateTime.Now) foundingShop = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public double TotalCost
        {
            get { return totalCost; }
            set
            {
                if (value > 0) totalCost = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public Product[] Products
        {
            get { return products; }
            set
            {
                if (value != null) products = value;
                else throw new ArgumentNullException();
            }
        }

        public double totalCostCalc
        {
            get
            {
                totalCost = 0; foreach (var product in products) { totalCost += (double)product.goodsPrice; }
                return totalCost;
            }

        }

        public int Count => products.Length;

        public bool IsDataSaved => throw new NotImplementedException();

        public bool this[ProductCategory type]
        {
            get
            {
                if (category == type)
                    return true;
                else return false;
            }
        }
        public void AddProduct(params Product[] newProducts)
        {
            Product[] addedProducts = new Product[products.Length + products.Length + newProducts.Length];

            Array.Copy(products, addedProducts, products.Length);
            Array.Copy(newProducts, 0, addedProducts, products.Length, newProducts.Length);

            products = addedProducts;
        }
        public void Delete(Product element)
        {
            int index = Array.IndexOf(products, element);
            if (index != -1)
            {
                Product[] newArray = new Product[products.Length - 1];
                Array.Copy(products, 0, newArray, 0, index);
                Array.Copy(products, index + 1, newArray, index, products.Length - index - 1);
                products = newArray;
            }
            isDataSaved = false;
        }

        public void Add(Product element)
        {
            if (element == null) return;

            Product[] newArray = new Product[products.Length + 1];
            Array.Copy(products, newArray, products.Length);
            newArray[products.Length] = element;

            products = newArray;
            isDataSaved = false;
        }
        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= products.Length)
                    throw new IndexOutOfRangeException($"Index {index} is out of bounds for the products array.");
                return products[index];
            }
            set
            {
                if (index < 0 || index >= products.Length)
                    throw new IndexOutOfRangeException($"Index {index} is out of bounds for the products array.");
                products[index] = (Product)value;
            }
        }
        public void Save(string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                foreach (var product in products)
                {
                    streamWriter.WriteLine($"{product.goodsName};{product.goodsPrice};{product.supplier.LastName}");
                }
            }
            isDataSaved = true;
        }
        public void Load(string fileName)
        {
            if (!File.Exists(fileName)) return;

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(';');

                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        string lastName = parts[2];

                        if (decimal.TryParse(parts[1], out decimal price))
                        {
                            Person supplier = new Person("Unknown", lastName, DateTime.Now);
                            Product p = new Product(supplier, name, price);

                            Add(p);
                        }
                    }
                }
            }

            isDataSaved = true;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < products.Length; i++)
            {
                yield return products[i];
            }
        }
        public void Sort()
        {
            Array.Sort(products);
            isDataSaved = false;
        }
    }
}
