namespace General
{
    public class FirTreeTextBuilder
    {
        public static void Build (int height)
        {
            string text = string.Empty;
            for (var i = height - 1; i >= 0; i--)
            {
                var primarySpace = StringOfSymbols(i, ' ');
                for (var j = 0; j < height - i; j++)
                {
                    text = primarySpace + StringOfSymbols(height - i - j - 1, ' ') + StringOfSymbols(j * 2 + 1, '*')
                        + StringOfSymbols(height - i - j - 1, ' ') + primarySpace;
                    ConsoleHelper.WriteText(text);
                }              
            }
        }


        //использование идентичного метода из предыдущего задания в данном случае считаю некорректным,
        //т.к. он находится в классе для построения треугольника, а не дерева.
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
