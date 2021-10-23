using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SigmaHT_8_2
{
    class Storage
    {
        public List<Product> Products { get; set; }

        public Storage()
        {
            Products = new List<Product>();
        }

        public Product this[int index]
        {
            get { return Products[index]; }
            set { Products.Add(value); }
        }

        public override string ToString()
        {
            string output = "\nProducts in the storage:";

            for (int i = 0; i < Products.Count; i++)
            {
                output += $"\n\n--- {i + 1} product ---\n";
                output += Products[i];
            }

            return output;
        }

        public List<Product> FindAllMeatProducts()
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].GetType() == typeof(Meat))
                    products.Add(Products[i]);
            }

            return products;
        }

        public void DeleteAllExpiredDairyProducts(string filePath)
        {
            int count = 0;

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].GetType() == typeof(Dairy_products)
                    && DateTime.Now > Products[i].ProductionDate.AddDays(Products[i].ExpirationDate))
                    count++;

            }

            List<Product> products = new List<Product>();

            for (int i = 0, j = 0; i < Products.Count; i++)
            {
                if (Products[i].GetType() == typeof(Dairy_products)
                    && DateTime.Now > Products[i].ProductionDate.AddDays(Products[i].ExpirationDate))
                {
                    PrintToFile(filePath, Products[i]);
                    continue;
                }

                products.Add(Products[i]);
                j++;
            }

            Products = products;

        }

        public void PrintToFile(string filePath, Product product)
        {
            StreamWriter streamWriter = new StreamWriter(filePath);

            streamWriter.WriteLine(product);

            streamWriter.Close();
        }

        public void ChangePriceForAllProducts(double percentage)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].ChangePrice(percentage);
            }
        }

    }
}
