using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -8, 13, 46, -269, 514 };
            string[] str = { "hello", "some", "string" };
            double num = 12.4;
            Product product = new Product("Fish", 15.24, DateTime.Today.AddDays(10));

            Product[] products = RandomProduct.GetRandomProducts(500);

            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            // ArrayList

            ArrayList arrLst = new ArrayList();

            // Добавление элементов

            // [i]  

            // Add 

            arrLst.Add(12);
            arrLst.Add(5.2);
            arrLst.Add("str");
            arrLst.Add(product);

            //Console.WriteLine(arrLst[1]);

            //foreach (var item in arrLst)
            //{
            //    Console.WriteLine(item);
            //}

            // AddRange

            arrLst.AddRange(nums);



            // Count VS Capacity
            arrLst.Add(3);

            Console.WriteLine(arrLst.Count);
            Console.WriteLine(arrLst.Capacity);

            // Insert

            arrLst.Insert(6, "Insert");
            arrLst.Insert(9, "Insert");
            foreach (var item in arrLst)
            {
                Console.WriteLine(item);
            }

            // IndexOf, LastIndexOf

            Console.WriteLine(arrLst.LastIndexOf("Insert52"));

            // Contains

            Console.WriteLine(arrLst.Contains(5.26));

            // Clear

            arrLst.Clear();

            foreach (var item in arrLst)
            {
                Console.WriteLine(item);
            }

            arrLst.Add(1);
            arrLst.Add(2);
            arrLst.Add(1);

            Console.WriteLine($"{arrLst.Count} / {arrLst.Capacity}");

            // Remove 

            //arrLst.Remove(1);

            // RemoveAt  

            //arrLst.RemoveAt(1);

            // RemoveRange            

            // ToArray

            object[] objArr = new object[arrLst.Count];

            objArr = arrLst.ToArray();

            // TrimToSize

            arrLst.TrimToSize();
            arrLst.Add(15);

            foreach (var item in objArr)
            {
                Console.WriteLine(item);
            }
            arrLst.TrimToSize();

            Console.WriteLine($"{arrLst.Count} / {arrLst.Capacity}");

            //List<Product> products = new List<Product>();

            //products.Add(product);
            //products.AddRange(RandomProduct.GetRandomProducts(10));




            //List<List<Product>> pr = new List<List<Product>>();




            //pr.Add(products);
            ////pr.AddRange(products);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.GetPrice());
            //}

            //Product[] productsArr = new Product[products.Count];
            //productsArr = products.ToArray<Product>();

            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add("Ukraine", "Kyiv");
            //dictionary.Add("Germany", "Berlin");

            //dictionary["Germany"] = "Munhen";

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}
        }
    }
}
