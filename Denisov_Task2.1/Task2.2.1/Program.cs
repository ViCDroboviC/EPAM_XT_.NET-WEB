using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.Write($"My Game Pre Alfa version 0.1\nPress any key to begin.");
            ConsoleHelper.PressAnyKey();
            GameSession.StartGame();

        }
    }
}
