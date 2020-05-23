using General;

namespace Task1._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm calculates the sum of all numbers, that  multiple of 3 or 5 from 0-1000 \n");           
            SummOfMultiple.FindAndCalculate();
            ConsoleHelper.PressAnyKey();
        }
    }
}
