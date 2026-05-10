using Labeighth.first;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labeighth.utility
{
    internal class FullTest
    {
        public static void Test() {
            Shop myShop = new Shop();
            myShop.ShopName = "Name";

            Console.WriteLine($"{myShop.ShopName}:");

            Console.WriteLine("\nAdd");
            for (int i = 0; i < 5; i++)
            {
                Product p = ShopGenerator.GenerateRandomProduct();
                myShop.Add(p);
                Console.WriteLine($" {p.goodsName}. {p.goodsPrice}. {p.supplier.LastName}");
            }

            Console.WriteLine("\nSort");
            myShop.Sort();
            foreach (Product product in myShop)
            {
                Console.WriteLine($"{product.goodsName} : {product.goodsPrice}");
            }

            Console.WriteLine("\nCopy");
            Shop smallShop = new Shop();
            smallShop.ShopName = "...";

            for (int i = 0; i < (myShop.Count < 3 ? myShop.Count : 3); i++)
            {
                Product original = (Product)myShop[i];
                smallShop.Add(original);
            }

            Console.WriteLine($"Shop: {smallShop.ShopName}. Number of product: {smallShop.Count}");

            smallShop.Save("save.txt");
            Console.WriteLine("\nSave in 'save.txt'");

        } 
    }
}
