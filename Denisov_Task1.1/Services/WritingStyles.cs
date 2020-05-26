using System;

namespace General
{
    public class WritingStyles
    {
        [Flags]
        enum Styles
        {
            none = 1,
            bold = 2,
            italic = 4,
            underline = 8
        }

        static Styles currentStyle = (Styles.none);
        public static void ShowWritingStyle()
        {
            ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
            currentStyle = currentStyle ^ Styles.none;
            ChangeStyle(ref currentStyle);
        }

        private static void ChangeStyle(ref Styles currentStyle)
            //И на этом методе я сломал голову.
            //На доводку уже не оставалось времени. Из улучшений считаю возможным сделать по методу для каждого кейса, чтобы улучшить читаемость.
        {           
            int theChoise = ConsoleHelper.ReadValue($"Choose one of allowed styles:\n1: {Styles.bold.ToString()}\n" +
                $"2: {Styles.italic.ToString()}\n3: {Styles.underline.ToString()}\n4: If style suits you\n");
            if (theChoise > 4
                )
            {
                theChoise = ConsoleHelper.ReadValue($"Variant {theChoise} does not exist. Enter existing variant.");
            }
            switch (theChoise)
            {
                case 1:
                    if (!currentStyle.HasFlag(Styles.bold))
                    {
                        currentStyle = currentStyle | Styles.bold;
                        ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                        ChangeStyle(ref currentStyle);
                    }
                    else
                    {
                        currentStyle = currentStyle ^ Styles.bold;
                        ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                        ChangeStyle(ref currentStyle);
                    }
                    break;
                case 2:
                    if (!currentStyle.HasFlag(Styles.italic))
                    {
                        currentStyle = currentStyle | Styles.italic;
                        ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                        ChangeStyle(ref currentStyle);
                    }
                    else
                    {
                        currentStyle = currentStyle ^ Styles.italic;
                        ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                        ChangeStyle(ref currentStyle);
                    }
                    break;
                case 3:
                    if (!currentStyle.HasFlag(Styles.underline))
                    {
                        currentStyle = currentStyle | Styles.underline;
                        ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                        ChangeStyle(ref currentStyle);
                    }
                    else
                    {
                        currentStyle = currentStyle ^ Styles.underline;
                        ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                        ChangeStyle(ref currentStyle);
                    }
                    break;
                case 4:
                    ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                    break;
                default:
                    throw new Exception("Unexpected exception.");
            }                
        }
    }
}
