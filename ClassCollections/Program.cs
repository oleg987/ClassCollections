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

            //Product[] products = new Product[500];

            //for (int i = 0; i < products.Length; i++)
            //{
            //    products[i] = RandomProduct.GetRandomProduct();
            //}

            //foreach (Product item in products)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

            // ArrayList

            // Конструкторы

            ArrayList arrayList = new ArrayList();

            ArrayList arrayList1 = new ArrayList(30);

            ArrayList arrayList2 = new ArrayList(nums);

            // Добавление элементов

            // [i]  

            // Add

            arrayList.Add(1);
            arrayList.Add("str");
            arrayList.Add(num);
            arrayList[1] = 18;
            arrayList.Add(1);
            arrayList.Add("str");
            arrayList.Add(num);



            // AddRange

            arrayList.AddRange(str);

            

            // Count VS Capacity

            Console.WriteLine(arrayList.Capacity);

            Console.WriteLine(arrayList.Count);

            // Insert

            arrayList.Insert(5, null);



            // IndexOf, LastIndexOf

            arrayList.IndexOf(1);

            // Contains

            arrayList.Contains("str");
            Console.WriteLine(arrayList.Contains("str"));

            // Clear

            arrayList2.Clear();

            // Remove

            arrayList.Remove(1);            

            // RemoveAt

            arrayList.RemoveAt(6);

            Console.WriteLine(arrayList);            

            // RemoveRange

            arrayList.RemoveRange(3, arrayList.Count - 3);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            // ToArray

            object[] arr = new object[5];


            // TrimToSize            


            ArrayList list = new ArrayList();
            list.Add(2);
            list.AddRange(new int[] { 1, 2, 6, 1, 9, 1 });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }            

            while (list.Contains(1))
            {
                list.Remove(1);
            }

            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Product[] arr1 = new Product[5];

            List<Product> products1 = new List<Product>();

            List<List<Product>> listInt = new List<List<Product>>();       



            Dictionary<int, Product> capitals = new Dictionary<int, Product>();

            Product[,] products = new Product[12, 31];
            
        }
    }
}
