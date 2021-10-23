using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_8_1
{
    delegate int CompareDelegate(object firstValue, object secondValue);

    class Algorithm
    {  
        static public void Sort(object[] array, CompareDelegate compare)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (compare(array[j], array[j + 1]) > 0)
                    {
                        object temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
