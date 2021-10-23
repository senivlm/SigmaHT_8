using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaHT_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker fileWorker = new FileWorker(@"C:\Users\User\source\repos\SigmaHT_8\SigmaHT_8_3\Input.txt");

            string sentence = fileWorker.GetSentenceWithMostNestedBracketsDepth();

            Console.WriteLine($"Sentence that has the most depth of nested brackets:\n{sentence}\n");

            List<string> sentences = fileWorker.GetAllSentences();

            sentences = sentences.OrderBy(i => i.Length).ToList();

            Console.WriteLine("Sorted sentences:\n");

            foreach (var item in sentences)
            {
                Console.WriteLine(item);
            }
        }
    }
}
