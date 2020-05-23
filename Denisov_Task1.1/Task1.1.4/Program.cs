using General;

namespace Task1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm builds a fir-tree from * symbols\nEnter the height of tree:\n");
            var treeHeight = ConsoleHelper.ReadValue("Enter the height:");
            ConsoleHelper.SetForeGroundColorGreen();
            FirTreeTextBuilder.Build(treeHeight);
            ConsoleHelper.PressAnyKey();
        }
    }
}
