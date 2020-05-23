using General;

namespace Task1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm builds a triangle from * symbols\n");
            var count = ConsoleHelper.ReadValue("Enter lines count:");
            ConsoleHelper.SetForeGroundColorGreen();
            TriangleTextBuilder.Build(count);
            ConsoleHelper.PressAnyKey();
        }
    }
}
