using System;

namespace Task_3._1._2
{
    public static class ConsoleHelper
    {
        public static string ReadText(string message)
        {
            string text = null;
            Console.WriteLine(message);
            do
            {
                text = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("You entered the empty text! Please enter nonempty text:");
                }
            }
            while (string.IsNullOrWhiteSpace(text));
            return text;
         
        }
        public static int ReadValue(string message)
        {
            int result;
            bool sucsess;
            do
            {
                Console.Write($"{message}");
                sucsess = int.TryParse(Console.ReadLine(), out result);
                if (!sucsess || result <= 0)
                {
                    Console.WriteLine("Enter a valid value.");
                }
            }
            while (!sucsess || result <= 0);
            return result;
        }
    }
}
