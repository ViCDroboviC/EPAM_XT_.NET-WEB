using System;
using System.Text;

namespace General
{
    public class StringProcessor
    {
        public static void FindAverageInSentence (string str)
        {
            string[] words = SplitToWords(str);
            var numberOfWords = 0;
            var numberOfSymbols = 0;
            foreach (string word in words)
            {
                numberOfWords++;
                numberOfSymbols += word.Length;
            }
            var average = numberOfSymbols / numberOfWords;
            ConsoleHelper.WriteText($"Number of words is: {numberOfWords}.\nAverage is: {average}");
        }

        public static void NumberOfLowerStartWods (string str)
        {
            string[] words = SplitToWords(str);
            var numberOfWords = 0;
            var numberOfLowerWords = 0;
            foreach (string word in words)
            {
                numberOfWords++;
                if (char.IsLower(word, 0))
                {
                    numberOfLowerWords++;
                }
            }
            ConsoleHelper.WriteText($"Number of words is: {numberOfWords}.\nStarts with lower: {numberOfLowerWords}");
        }

        private static string[] SplitToWords(string str)
        {
            string[] separators = { " ", ",", ".", "-", ":", ";", "!", "?" };
            string [] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        public static void DoubleMatches(string str1, string str2)
        {
            ConsoleHelper.WriteText($"вошло в метод:{str1} {str2}");
            var secondString = DeleteMatches(str2);
            ConsoleHelper.WriteText($"пришло после удаления задвоений: {secondString}");
            ConsoleHelper.PressAnyKey();
            StringBuilder doubledString = new StringBuilder();
            for (int i = 0; i < str1.Length; i++)
            {
                doubledString.Append(str1[i], 1);
                foreach (char symbol in secondString)
                {
                    if (str1[i].Equals(symbol))
                    {
                        doubledString.Append(str1[i], 1);
                    }
                }
            }
            ConsoleHelper.WriteText($"{doubledString.ToString()}");
        }

        private static string DeleteMatches (string str)
        {
            string resultString = string.Empty;
            foreach(var symbol in str)
            {
                if (!resultString.Contains(symbol.ToString()))
                {
                    resultString += symbol;
                }
            }
            return resultString;
        }
    }
}
