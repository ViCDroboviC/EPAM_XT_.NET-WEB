using General;
using System;
using System.Collections.Generic;

namespace Task2._2._2
{
    public class PaintingDesk
    {
        static List<IPrintable> paintingSpace = new List<IPrintable>();

        public static void Start()
        {
            paintingSpace.Add(DrawingTool.DrawFigure());
            bool end = false;
            do
            {
                switch (ChooseAction())
                {
                    case 1:
                        ShowAll();
                        Console.Clear();
                        break;
                    case 2:
                        paintingSpace.Add(DrawingTool.DrawFigure());
                        break;
                    case 3:
                        ClearDesk();
                        break;
                    case 4:
                        end = true;
                        break;
                    default:
                        throw new Exception("Unexpected exception!");
                }
            }
            while (!end);
        }

        private static int ChooseAction()
        {
            bool res;
            int result = 0;
            ConsoleHelper.Write($"Press key to choose next action:\n1 - To show all figures on the desk;\n2 - To add new figure;\n 3 - To clear the desk;\n 4 - To Exit.");

            do
            {
                res = int.TryParse(Console.ReadLine(), out result);
                if (!res && result >= 5)
                {
                    ConsoleHelper.Write($"Enter the existing choose!");
                }
            }
            while (!res && result >= 5);
            return result;
        }

        private static void ShowAll()
        {
            foreach (IPrintable figure in paintingSpace)
            {
                figure.Print();             
            }
            ConsoleHelper.PressAnyKey();
        }

        private static void ClearDesk()
        {
            paintingSpace.Clear();
        }
    }
}
