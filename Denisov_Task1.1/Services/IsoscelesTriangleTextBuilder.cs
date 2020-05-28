namespace General
{
    public class IsoscelesTriangleTextBuilder
    {
        public static void Build(int count)
        {
            string text = string.Empty;
            for (int i = 0; i < count; i++)
            {
                text = StringOfSymbols(count - i - 1, ' ') + StringOfSymbols(i * 2 + 1, '*') + StringOfSymbols(count - i - 1, ' ');
                ConsoleHelper.WriteText(text);
            }
        }

        private static string StringOfSymbols(int count, char symbol)
        {
            string text = string.Empty;
            for (int i = 0; i < count; i++)
            {
                text = text + symbol;
            }
            return text;
        }
    }
}
