using System;
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
            return mass.();
        }
    }
}
