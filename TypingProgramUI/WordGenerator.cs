using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TypingProgramUI
{
    public class WordGenerator
    {
        public User user;
        public string[] words;
        public Random rnd = new Random();

        public WordGenerator(User user)
        {
            this.user = user;
            StreamReader reader = new StreamReader(@"C:\Users\joeya\Desktop\Programming Files\C#\MostCommonWords.txt");
            string word;
            List<string> commonWords = new List<string>();
            while ((word = reader.ReadLine()) != null)
            {
                commonWords.Add(word);
            }
            words = commonWords.ToArray();

            reader.Close();
        }

        public string generateWord()
        {
            char neededChar = this.user.chooseChar();
            string rndWord;
            do
            {
                rndWord = words[rnd.Next(0, words.Length)];
            } while (!(rndWord.Contains(neededChar)));
            return rndWord;
        }

        public void missedChar(int missedChar)
        {
            user.changePercentages(missedChar);
        }
    }
}
