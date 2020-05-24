using General;

namespace Task1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm generates and sorts the random one-dimensional array and finds it min/max values.\n");
            int [] array = ArrayGenerator.GenerateOneDimensional();
            ArrayProcessor.FindMax(array);
            ArrayProcessor.FindMin(array);
            ArrayProcessor.BubbleSort(array);
            ConsoleHelper.PressAnyKey();
        }
    }
}
