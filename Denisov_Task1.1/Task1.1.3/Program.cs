using General;

namespace Task1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm builds a triangle from * symbols\n");
            var count = ConsoleHelper.ReadValue("Enter lines count:");
            ConsoleHelper.SetForeGroundColorGreen();
            IsoscelesTriangleTextBuilder.Build(count);
            ConsoleHelper.PressAnyKey();
        }
    }
}
