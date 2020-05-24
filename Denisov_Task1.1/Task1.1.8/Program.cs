using General;

namespace Task1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm generates and sorts the random three-dimensional array and replaces all positive values with 0\n");
            int[, ,] array = ArrayGenerator.GenerateThreeDimensional();
            ConsoleHelper.WriteText($"Press any key to replace...");
            ConsoleHelper.PressAnyKey();
            ArrayProcessor.ReplaceAllPositive(array);
            ConsoleHelper.PressAnyKey();
        }
    }
}
