using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
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

        public static void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public static void PressAnyKey()
        {
            Console.ReadKey();
        }

        public static void SetForeGroundColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
