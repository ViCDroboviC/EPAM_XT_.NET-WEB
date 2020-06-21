using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.Write($"Kompass 0,99D CAD system. \nNonexistent systems 2020.\nAll rights not reserved.\nPress any key to continue...");
            ConsoleHelper.PressAnyKey();
            Console.Clear();
            PaintingDesk.Start();
            ConsoleHelper.PressAnyKey();
        }
    }
}
