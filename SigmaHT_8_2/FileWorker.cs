using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SigmaHT_8_2
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
        public Storage GetProducts()
        {
            string[] products = Text.Replace("\r\n", "\n").Split('\n');

            Storage storage = new Storage(); 

            for (int i = 0; i < products.Length; i++)
            {
                Product product = new Product();

                switch (products[i].Split(' ')[0])
                {
                    case "Ordinary:": product = new Product(); break;
                    case "Meat:": product = new Meat(); break;
                    case "Dairy:": product = new Dairy_products(); break;
                }
                try
                {
                    product.Parse(products[i]);
                }
                catch (ArgumentException)
                {
                    throw;
                }

                storage[i] = product;
            }

            return storage;
        }
    }
}
