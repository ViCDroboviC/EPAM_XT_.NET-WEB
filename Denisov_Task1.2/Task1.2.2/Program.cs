using General;

namespace Task1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm doubles all matching symbols from two strings.");
            var str1 = "написать программу, которая";
            var str2 = "описание";
            StringProcessor.DoubleMatches(str1, str2);
            ConsoleHelper.PressAnyKey();
        }
    }
}
