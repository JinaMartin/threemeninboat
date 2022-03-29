using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace threemeninboat
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Words = new Dictionary<string, int>();
            Dictionary<char, int> Letters = new Dictionary<char, int>();
            using (StreamReader sr = new StreamReader("ThreeMenInABoatEnglish.txt"))
            {
                string text = sr.ReadToEnd();
                string[] words = text.Split(new string[] { " ", ".", "," , "?", "!", "\\n", "\\r", "_"}, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (Words.ContainsKey(word))
                    {
                        Words[word]++;
                        continue;
                    }

                    Words.Add(word, 1);
                }

                char[] wrongEntries = { ' ', '_', '.', ',', '?', '!', '/', '\\' };

                foreach (char letter in text)
                {
                    if (wrongEntries.Contains<letter>)
                    if (Letters.ContainsKey(letter))
                    {
                        Letters[letter]++;
                        continue;
                    }
                    Letters.Add(letter, 1);
                }
            }

            Console.Read();
        }
    }
}
