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
        static int rand = 1;
        public static Product GetRandomProduct()
        {            
            Random random = new Random(rand++);

            string[] titles = { "Milk", "Apple", "Meat", "Rice", "Potato" };

            Product product = new Product(titles[random.Next(titles.Length)], Math.Round(random.NextDouble() * 100 + 1, 2), DateTime.Today.AddDays(random.Next(1, 60)));            

            return product;
        }
    }
}
