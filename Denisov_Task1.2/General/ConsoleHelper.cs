using System;

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

        public static void WriteArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(String.Format("{0, 4}", i));
            }
            Console.WriteLine();
        }

        public static void WriteTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0, 4}", array[i, j]));
                }
                WriteText("");
            }
        }

        public static void WriteThreeDimensionalArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                WriteText($"\nlayer {i}:");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int n = 0; n < array.GetLength(2); n++)
                    {
                        Console.Write(String.Format("{0, 3}", array[i, j, n]));
                    }
                    WriteText("");
                }
            }
            Console.WriteLine();
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
