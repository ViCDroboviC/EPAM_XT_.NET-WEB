using General;

namespace Task1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm contains different writing styles.\nPress any key to continue.");
            ConsoleHelper.PressAnyKey();
            ConsoleHelper.SetForeGroundColorGreen();
            WritingStyles.ShowWritingStyle();
            ConsoleHelper.PressAnyKey();
        }
    }
}
