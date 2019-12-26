using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassCollections
{
    static class RandomProduct
    {    
        public static Product[] GetRandomProducts(int count)
        {
            Random random = new Random();

            Product[] products = new Product[count];

            string[] titles = { "Milk", "Apple", "Meat", "Rice", "Potato" };

            for (int i = 0; i < count; i++)
            {
                products[i] = new Product(titles[random.Next(titles.Length)], Math.Round(random.NextDouble() * 100 + 1, 2), DateTime.Today.AddDays(random.Next(1, 60)));
            }

            return products;
        }
    }
}
