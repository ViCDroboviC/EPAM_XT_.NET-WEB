using General;

namespace Task2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text1 = new Text("abcdef".ToCharArray());
            Text text2 = new Text("ghijkl".ToCharArray());
            var text3 = text1 + text2;
            ConsoleHelper.Write(text3);
            ConsoleHelper.PressAnyKey();
        }
    }
}
