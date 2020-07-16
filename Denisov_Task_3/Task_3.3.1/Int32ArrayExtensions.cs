using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3._3._1
{
    public static class Int32ArrayExtensions
    {
        public delegate int ElementModifier(int x);

        public static void Modify (this int[] mass, ElementModifier Modifier)
        {
            for(int i = 0; i < mass.Length; i++)
            {
                mass[i] = Modifier(mass[i]);
            }
        }

        public static int FindTotalSum (this int[] mass)
        {
            return mass.Sum();
        }

        public static Double FindAverage(this int[] mass)
        {
            return mass.Average();
        }

        public static int FindMostRepeating(this int[] mass)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            KeyValuePair<int, int> mostRepeating = new KeyValuePair<int, int>(0, 0);
            foreach (int number in mass)
            {
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
            }

            foreach(KeyValuePair<int, int> word in numbers)
            {
                mostRepeating = new KeyValuePair<int, int>(0, 0);
                if (word.Value > mostRepeating.Value)
                {
                    mostRepeating = word;
                }
            }
            return mostRepeating.Key;
        }
    }
}
