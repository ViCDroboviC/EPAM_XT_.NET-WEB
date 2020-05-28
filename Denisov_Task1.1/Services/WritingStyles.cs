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
                    currentStyle = currentStyle ^ Styles.bold;
                    if (currentStyle == 0)
                    {
                        currentStyle = (Styles.none);
                    }
                    RemoveNoneIfNeeded(ref currentStyle);
                    ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                    ChangeStyle(ref currentStyle);                   
                    break;
                case 2:
                    currentStyle = currentStyle ^ Styles.italic;
                    if (currentStyle == 0)
                    {
                        currentStyle = (Styles.none);
                    }
                    RemoveNoneIfNeeded(ref currentStyle);
                    ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                    ChangeStyle(ref currentStyle);
                    break;
                case 3:
                    currentStyle = currentStyle ^ Styles.underline;
                    if (currentStyle == 0)
                    {
                        currentStyle = (Styles.none);
                    }
                    RemoveNoneIfNeeded(ref currentStyle);
                    ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                    ChangeStyle(ref currentStyle);
                    break;
                case 4:
                    ConsoleHelper.WriteText($"Current style is {currentStyle.ToString()}\n");
                    break;
                default:
                    throw new Exception("Unexpected exception.");
            }            
        }

        private static void RemoveNoneIfNeeded(ref Styles currentStyle)
        {
            if (currentStyle.HasFlag(Styles.none))
            {
                if (currentStyle.HasFlag(Styles.bold) | currentStyle.HasFlag(Styles.italic) | currentStyle.HasFlag(Styles.underline))
                {
                    currentStyle = currentStyle ^ Styles.none;
                }
            }
        }
    }
}
