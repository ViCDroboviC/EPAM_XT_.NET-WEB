using General;

namespace Task1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm generates the random one-dimensional array and calculates sum of its non-negative values.\n");
            int[] array = ArrayGenerator.GenerateOneDimensional();
            ArrayProcessor.CalculateNonNegativeSumm(array);
            ConsoleHelper.PressAnyKey();           
        }
    }
}
