using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { ' ', '.', ',' });
            Dictionary<string, int> occurrences = new Dictionary<string, int> { };
            foreach (string w in words)
            {
                if (occurrences.ContainsKey(w))
                {
                    occurrences[w] += 1;
                }
                else
                {
                    occurrences[w] = 1;
                }
            }

            int highestCount = 0;
            string mostCommonWord = null;
            foreach (KeyValuePair<string, int> pair in occurrences)
            {
                if (pair.Value > highestCount && pair.Key != "")
                {
                    highestCount = pair.Value;
                    mostCommonWord = pair.Key;
                }
            }

            Console.WriteLine("Most common word: " + mostCommonWord);
        }
    }
}
