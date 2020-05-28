using General;

namespace Task1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm calculates average amount of symbols in sentence words.");
            var str = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате.";
            //Результат не округляется.
            StringProcessor.FindAverageInSentence(str);
            ConsoleHelper.PressAnyKey();
        }
    }
}
