using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SigmaHT_8_3
{ А якщо речення буде в кількох стрічках, де опрацьована така ситуація?
    class FileWorker
    {
        public List<string> lines;

        public FileWorker(string filePath)
        {
            lines = new List<string>();

            foreach (string line in System.IO.File.ReadLines(filePath))
            {
                lines.Add(line);
            }
        }

        public List<string> GetAllSentences()
        {
            List<string> sentences = new List<string>();

            string sentence = String.Empty;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] lineValues = lines[i].Split(' ');

                for (int j = 0; j < lineValues.Length; j++)
                {
                    sentence += lineValues[j];

                    if (lineValues[j].Contains("."))
                    {
                        sentences.Add(sentence);
                        sentence = String.Empty;
                        continue;
                    }

                    sentence += " ";
                }
            }

            return sentences;
        }

        private int CountMostNestedBracketsDepth(string sentence)
        {
            List<int> depths = new List<int>();
            depths.Add(0);

            int count = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == '(')
                    count++;

                if (sentence[i] == ')')
                {
                    depths.Add(count);
                    count = 0;
                }

            }

            return depths.Max();
        }

        public string GetSentenceWithMostNestedBracketsDepth()
        {
            List<string> sentences = GetAllSentences();

            int[] counts = new int[sentences.Count];

            for (int i = 0; i < sentences.Count; i++)
            {
                counts[i] = CountMostNestedBracketsDepth(sentences[i]);
            }

            int index = Array.IndexOf(counts, counts.Max());

            return sentences[index];
        } 
    }
}
