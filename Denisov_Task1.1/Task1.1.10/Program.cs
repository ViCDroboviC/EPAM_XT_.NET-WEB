using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm generates the random two-dimensional array and finds summ of even values.\n");
            int[,] array = ArrayGenerator.GenerateTwoDimensional();
            ArrayProcessor.CalculateSummOfEven(array);
            ConsoleHelper.PressAnyKey();
        }
    }
}
