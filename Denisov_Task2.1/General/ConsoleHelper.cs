using System;

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

        public static int ReadValue(string text)
        {
            int result;
            bool sucsess;
            do
            {
                Console.Write($"{text}");
                sucsess = int.TryParse(Console.ReadLine(), out result);
                if (!sucsess || result <= 0)
                {
                    Console.WriteLine("Enter a valid value.");
                }
            }
            while (!sucsess || result <= 0);
            return result;
        }

        public static string ReadString (string message)
        {
            string str = null;
            Write(message);
            do
            {
                str = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(str))
                {
                    Write($"Enter the valid text!");
                }
            }
            while (string.IsNullOrWhiteSpace(str));
            return str;
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
