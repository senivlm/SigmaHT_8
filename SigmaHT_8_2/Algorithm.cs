using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_8_2
{
    class Algorithm
    {
        static public List<T> FindIntersection<T>(List<T> firstList, List<T> secondList)
        {
            List<T> intersection = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i].Equals(secondList[j]) && !intersection.Contains(firstList[i]))
                        intersection.Add(firstList[i]);
                }
            }

            return intersection;
        }

        static public List<T> FindDifference<T>(List<T> firstList, List<T> secondList)
        {
            List<T> difference = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (!secondList.Contains(firstList[i]))
                    difference.Add(firstList[i]);
            }

            return difference;
        }

        static public List<T> FindSymmetricDifference<T>(List<T> firstList, List<T> secondList)
        {
            List<T> symmetricDifference = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (!secondList.Contains(firstList[i]))
                    symmetricDifference.Add(firstList[i]);
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (!firstList.Contains(secondList[i]))
                    symmetricDifference.Add(secondList[i]);
            }

            return symmetricDifference;
        }
    }
}
