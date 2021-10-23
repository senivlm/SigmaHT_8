using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker fileWorker = new FileWorker(@"C:\Users\User\source\repos\SigmaHT_8\SigmaHT_8\Products.txt");

            List<Product> productsList = fileWorker.GetProducts();

            Product[] productsArray = productsList.ToArray();

            
            Algorithm.Sort(productsArray, Compare.CompareProductsByPrice);

            Console.WriteLine("Products sorted by price:\n");
            for (int i = 0; i < productsArray.Length; i++)
            {
                Console.WriteLine(productsArray[i]);
            }

            Algorithm.Sort(productsArray, Compare.CompareProductsByWeight);

            Console.WriteLine("Products sorted by weight:\n");
            for (int i = 0; i < productsArray.Length; i++)
            {
                Console.WriteLine(productsArray[i]);
            }
        }
    }
}
