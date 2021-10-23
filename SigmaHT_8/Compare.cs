using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_8_1
{
    class Compare
    {
        static public int CompareProductsByPrice(object firstValue, object secondValue)
        {
            Product product1 = (Product)firstValue;
            Product product2 = (Product)secondValue;

            return product1.Price.CompareTo(product2.Price);
        }

        static public int CompareProductsByWeight(object firstValue, object secondValue)
        {
            Product product1 = (Product)firstValue;
            Product product2 = (Product)secondValue;

            return product1.Weight.CompareTo(product2.Weight);
        }
    }
}
