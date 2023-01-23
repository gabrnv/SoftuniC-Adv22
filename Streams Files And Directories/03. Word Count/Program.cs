using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _03._Word_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> repeatedWords = new Dictionary<string, int>();
            StreamReader reader = new StreamReader(@"../../../words.txt");
            string words = reader.ReadToEnd();
            List<string> wordList = words.Split().ToList();
            reader.Close();

            StreamReader textReader = new StreamReader(@"../../../text.txt");
            string text = textReader.ReadToEnd();//.Remove('-').Remove('!').Remove(',').Remove('.').Remove('?');
            text = text.Replace('-', ' ');
            text = text.Replace('.', ' ');
            text = text.Replace(',', ' ');
            text = text.Replace('!', ' ');
            text = text.Replace('?', ' ');
            List<string> textList = text.Split().ToList();
            textReader.Close();

            StreamWriter writer = new StreamWriter(@"../../../output.txt");

            foreach (string word in wordList)
            {
                repeatedWords.Add(word, 0);
            }

            foreach (string word in textList)
            {
                string newWord = word.ToLower();
                
                if(wordList.Contains(newWord))
                {
                    repeatedWords[newWord]++;
                }

            }
            var sortedDict = from entry in repeatedWords orderby entry.Value descending select entry;
            foreach (var word in sortedDict)
            {
                writer.WriteLine($"{word.Key} {word.Value}");
            }

            writer.Close();
        }
    }
}
