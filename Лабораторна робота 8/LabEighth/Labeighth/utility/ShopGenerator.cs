using Labeighth.first;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labeighth.utility
{
    internal class ShopGenerator
    {
        private static Random random = new Random();

        private static string[] firstNames = { "firstName1", "firstName2", "firstName3"};
        private static string[] lastNames = { "LastName1", "LastName2", "LastName3", "LastNameр4", "LastName5" };

        private static string[] productNames = { "1", "2", "3", "4", "5", "6" };

        public static Product GenerateRandomProduct()
        {
            string firstName = firstNames[random.Next(firstNames.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];
            DateTime birthday = new DateTime(random.Next(1970, 2005), random.Next(1, 13), random.Next(1, 28));

            Person supplier = new Person(firstName, lastName, birthday);

            string pName = productNames[random.Next(productNames.Length)] + "-" + random.Next(10, 99);
            decimal price = random.Next(200, 15000);

            return new Product(supplier, pName, price);
        }
    }
}
