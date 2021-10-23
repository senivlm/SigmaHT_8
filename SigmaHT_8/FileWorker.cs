using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SigmaHT_8_1
{
    class FileWorker
    {
        public string Text { get; set; }

        public FileWorker(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                Text = reader.ReadToEnd();
            }
        }
        public List<Product> GetProducts()
        {
            string[] products = Text.Replace("\r\n", "\n").Split('\n');

            List<Product> productsList = new List<Product>();

            for (int i = 0; i < products.Length; i++)
            {
                Product product = new Product();

                try
                {
                    product.Parse(products[i]);
                }
                catch (ArgumentException)
                {
                    throw;
                }

                productsList.Add(product);
            }

            return productsList;
        }
    }
}
