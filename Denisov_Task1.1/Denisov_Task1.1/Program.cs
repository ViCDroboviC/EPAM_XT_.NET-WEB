using General;

namespace Denisov_Task1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleHelper.WriteText($"Greetings!\nThis programm calculates the area of rectangle.\nEnter the side lengths sequentially:\n");
            var a = ConsoleHelper.ReadValue("Length of side a is:");
            var b = ConsoleHelper.ReadValue("Length of side b is:");
            
            var s = a * b;
            ConsoleHelper.WriteText($"Area of rectangle is: {s}");
            ConsoleHelper.PressAnyKey();
        }
    }
}
