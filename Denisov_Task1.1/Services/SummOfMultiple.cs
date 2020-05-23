namespace General
{
    public class SummOfMultiple
    {
        public static void FindAndCalculate()
        {
            int summ = 0;
            for (int i = 0; i<1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summ = summ + i;
                }
            }
            ConsoleHelper.WriteText($"{summ}");
        }
    }
}
