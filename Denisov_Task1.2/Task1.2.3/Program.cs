using General;

namespace Task1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm calculates number of words, that starts from lower.");
            var str = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны.";
            StringProcessor.NumberOfLowerStartWods(str);
            ConsoleHelper.PressAnyKey();
        }
    }
}
