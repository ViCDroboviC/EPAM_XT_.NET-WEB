using System;
using System.Collections.Generic;

namespace Task_3._1._2
{
    public static class TextProcessor
    {
        public static void Analyse(string text)
        {
            string[] splittedText = Split(text);
            Dictionary<string, int> textWords = new Dictionary<string, int>();
            foreach(string word in splittedText)
            {
                if (!textWords.ContainsKey(word.ToLower()))
                {
                    textWords.Add(word, 1);
                }
                else if (textWords.ContainsKey(word.ToLower()))
                {
                    textWords[word]++;
                }
            }

            int wantedLevelOfFrequency = ConsoleHelper.ReadValue("Enter the max number of repeats for one word in your text.");
            bool isTextIsGood = true;

            foreach(KeyValuePair<string, int> word in textWords)
            {
                if(word.Value >= wantedLevelOfFrequency)
                {
                    Console.WriteLine($"Word {word.Key} repeats too often.");
                    isTextIsGood = false;
                }
            }

            if (isTextIsGood)
            {
                Console.WriteLine("This text is good.");
            }
            else if (!isTextIsGood)
            {
                Console.WriteLine("Try to work with repeating words.");
            }
        }

        private static string[] Split(string text)
        {
            string[] separators = { " ", ",", ".", "-", ":", ";", "!", "?" };
            string[] res = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return res;
        }
    }
}
