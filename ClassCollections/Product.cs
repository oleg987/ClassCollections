using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollections
{
    class Product
    {
        static int currentId = 1;

        int id;
        string title;
        double price;
        DateTime expired;

        public string Title { get => title; set => title = value; }
        public double Price { get => price; set => price = value; }
        public DateTime Expired { get => expired; set => expired = value; }

        public Product(string title, double price, DateTime expired)
        {
            id = currentId++;
            Title = title;
            Price = price;
            Expired = expired;
        }

        public override string ToString()
        {
            return $"ID: {id}\tTitle: {title}\tPrice: {price}\tExpired: {expired.ToShortDateString()}";
        }
    }
}
