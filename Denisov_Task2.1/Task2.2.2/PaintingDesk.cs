using General;
using System;
using System.Collections.Generic;

namespace Task2._2._2
{
    public class PaintingDesk
    {
        List<IPrintable> paintingSpace = new List<IPrintable>();

        public void Start()
        {
            DrawingTool.DrawFigure();
            switch (ChooseAction())
            {
                case 1:
                    break;
                case 2:
                    DrawingTool.DrawFigure();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    throw new Exception("Unexpected exception!");
            }
        }

        private int ChooseAction()
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
    }
}
