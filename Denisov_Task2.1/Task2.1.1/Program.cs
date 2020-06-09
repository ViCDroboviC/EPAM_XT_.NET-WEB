using General;
using System;

namespace Task2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text1 = new Text("Abcdef");
            Text text2 = new Text("abcdef");
            var text3 = text1 + text2;
            var comparsion = text1 == text2;
            ConsoleHelper.Write($"{comparsion}");
            ConsoleHelper.PressAnyKey();
        }
    }
}
