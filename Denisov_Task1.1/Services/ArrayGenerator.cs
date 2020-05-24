using System;

namespace General
{
    public class ArrayGenerator
    {
        public static int [] GenerateOneDimensional()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 30);
            int[] newarray = new int[a];
            for (int i = 0; i < newarray.Length; i++)
            {
                newarray[i] = rnd.Next(-99, 99);
            }
            ConsoleHelper.WriteText($"New array is:");
            ConsoleHelper.WriteArray(newarray);
            return newarray;
        }

        public static int [,] GenerateTwoDimensional()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 15);
            int b = rnd.Next(1, 15);
            int[,] newarray = new int[a, b];
            for (int i = 0; i < newarray.GetLength(0); i++)
            {
                for (int j = 0; j < newarray.GetLength(1); j++)
                {
                    newarray[i, j] = rnd.Next(1, 50);
                }
            }
            ConsoleHelper.WriteText($"New array is:");
            ConsoleHelper.WriteTwoDimensionalArray(newarray);
            return newarray;
        }

        public static int[, ,] GenerateThreeDimensional()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 10);
            int y = rnd.Next(1, 10);
            int z = rnd.Next(1, 10);
            int[, ,] newarray = new int[x,y,z];
            for (int i = 0; i < newarray.GetLength(0); i++)
            {
                for (int j = 0; j < newarray.GetLength(1); j++)
                {
                    for (int n = 0; n < newarray.GetLength(2); n++)
                    {
                        newarray[i,j,n] = rnd.Next(-10, 10);
                    }
                }               
            }
            ConsoleHelper.WriteText($"New array is:");
            ConsoleHelper.WriteThreeDimensionalArray(newarray);
            return newarray;
        }
    }
}
