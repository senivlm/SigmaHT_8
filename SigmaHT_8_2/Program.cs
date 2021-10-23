using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker fileWorker1 =
                new FileWorker(@"C:\Users\User\source\repos\SigmaHT_8\SigmaHT_8_2\Storage1.txt");
            FileWorker fileWorker2 = 
                new FileWorker(@"C:\Users\User\source\repos\SigmaHT_8\SigmaHT_8_2\Storage2.txt");

            Storage storage1 = fileWorker1.GetProducts();

            Storage storage2 = fileWorker2.GetProducts();

            var productsIntersection = Algorithm.FindIntersection(storage1.Products, storage2.Products);

            var productsDifference = Algorithm.FindDifference(storage1.Products, storage2.Products);

            var productsSymmetricDifference = Algorithm.FindSymmetricDifference(storage1.Products, 
                storage2.Products);

            Console.WriteLine("Intersection of products:\n");

            for (int i = 0; i < productsIntersection.Count; i++)
            {
                Console.WriteLine(productsIntersection[i]);
            }

            Console.WriteLine("Difference of first and second storage:\n");

            for (int i = 0; i < productsDifference.Count; i++)
            {
                Console.WriteLine(productsDifference[i]);
            }

            Console.WriteLine("Symmetric difference of products:\n");

            for (int i = 0; i < productsSymmetricDifference.Count; i++)
            {
                Console.WriteLine(productsSymmetricDifference[i]);
            }
        }

    }
}
