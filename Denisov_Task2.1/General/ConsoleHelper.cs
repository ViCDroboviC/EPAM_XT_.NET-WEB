using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class ConsoleHelper
    {
        public static void Write(string str)
        {
            Console.WriteLine(str);
        }

        public static void Write(Text text)
        {
           string str = text.ToString();
           Console.WriteLine(str); 
        }

        public static void PressAnyKey()
        {
            Console.ReadKey();
        }

        public Text ReadText(string message)
        {
            Text newText;
            Write(message);
            string enteredText;
            do
            {
                enteredText = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(enteredText))
                {
                    Write($"Text cannot be empty!\n{message}");
                }
            }
            while (string.IsNullOrWhiteSpace(enteredText));
            newText = new Text(enteredText.ToCharArray());
            return newText;
        }
    }
}
