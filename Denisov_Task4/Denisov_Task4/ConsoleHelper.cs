using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denisov_Task4
{
    public static class ConsoleHelper
    {
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

        public static string ReadString(string message)
        {
            string result;

            do
            {
                Console.Write($"{message}");
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result)) 
                {
                    Console.WriteLine("Enter a valid value.");
                }
            }
            while (string.IsNullOrEmpty(result));
            return result;
        }

        public static void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
