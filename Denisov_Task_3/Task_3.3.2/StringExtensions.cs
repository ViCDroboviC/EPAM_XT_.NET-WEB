using System;
using System.Text.RegularExpressions;

namespace Task_3._3._2
{
    public static class StringExtensions
    {
        public static void CheckLanguageOfWord(this string word)
        {
            bool isRussian = false;
            bool isEnglish = false;
            bool isNumber = false;
            #region FirstTry
            //char[] russianAlphaphet = new char[] {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о',
            //'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
            //string[] EnglishAlphaphet = new string[] { };

            //foreach(char symbol in word)
            //{
            //    foreach(var sumb in russianAlphaphet)
            //    {
            //        symbol.CompareTo(sumb)
            //    }
            //}
            #endregion
            Regex russian = new Regex(@"[а-яё]", RegexOptions.IgnoreCase);
            Regex english = new Regex(@"[a-z]", RegexOptions.IgnoreCase);
            Regex numbers = new Regex(@"[0-9]");

            if (russian.IsMatch(word))
            {
                isRussian = true;
            }

            if (english.IsMatch(word))
            {
                isEnglish = true;
            }

            if (numbers.IsMatch(word))
            {
                isNumber = true;
            }

            if(isRussian && !isEnglish && !isNumber)
            {
                Console.WriteLine("Russian Word");
            }
            else if(!isRussian && isEnglish && !isNumber)
            {
                Console.WriteLine("English Word");
            }
            else if(!isRussian && !isEnglish && isNumber)
            {
                Console.WriteLine("Nubers");
            }
            else
            {
                Console.WriteLine("Mixed Word");
            }
        }
    }
}
