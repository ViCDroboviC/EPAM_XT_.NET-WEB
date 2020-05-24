using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class ArrayProcessor
    {
        public static void FindMax(int [] array)
        {
            int max = array[0];
            foreach (int i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            ConsoleHelper.WriteText($"Max value is {max}");
        }

        public static void FindMin(int[] array)
        {
            int min = array[0];
            foreach (int i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            ConsoleHelper.WriteText($"Min value is {min}");
        }

        public static void BubbleSort (int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        int a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
            }
            ConsoleHelper.WriteText($"Sorted array is:");
            ConsoleHelper.WriteArray(array);
        }

        public static void ReplaceAllPositive (int [,,] array)
        {
            int numberOfReplaces = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int n = 0; n < array.GetLength(2); n++)
                    {
                        if (array[i,j,n] > 0)
                        {
                            numberOfReplaces = numberOfReplaces + 1;
                            array[i, j, n] = 0;
                        }
                    }
                }
            }
            ConsoleHelper.WriteText($"Array after replacing:");
            ConsoleHelper.WriteThreeDimensionalArray(array);
            ConsoleHelper.WriteText($"Replaced: {numberOfReplaces} values.");
        }

        public static void CalculateNonNegativeSumm (int [] array)
        {
            int summ = 0;
            int min = array[0];
            foreach (int i in array)
            {
                if (i > 0)
                {
                    summ = summ + i;
                }
            }
            ConsoleHelper.WriteText($"Summ of all positive values is: {summ}");
        }

        public static void CalculateSummOfEven (int [,] array)
        {
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    switch (i + j % 2)
                    {
                        case 0:
                            summ = summ + array[i, j];
                            break;
                        case 1:
                            break;
                    }
                }
            }
            ConsoleHelper.WriteText($"Summ is: {summ}");
        }
    }
}
