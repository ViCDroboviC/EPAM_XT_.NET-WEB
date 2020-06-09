using General;
using System;

namespace Task2._2._2
{
    class DrawingTool
    {
        public static IPrintable DrawFigure()
        {
            ConsoleHelper.Write("Choose the type of figure, that you desire to draw. \nAwailiable figures:");
            ShowTypesOfFigures();
            return ChooseFigureType();
        }

        private static IPrintable ChooseFigureType()
        {
            var str = Console.ReadLine();

            var type = (FigureTypes)Enum.Parse(typeof(FigureTypes), str);

            switch (type)
            {
                case FigureTypes.Line:
                    return DrawLine();
                case FigureTypes.Circle:
                    return DrawCircle();
                case FigureTypes.Range:
                    return DrawRange();
                case FigureTypes.Ring:
                    return DrawRing();
                case FigureTypes.Triangle:
                    return DrawTriangle();
                case FigureTypes.RegularTetragon:
                    return DrawRegularTetragon();
                case FigureTypes.Rectangle:
                    return DrawRectangle();
                default: throw new Exception("Unexpected exception!");
            }
        }

        private static void ShowTypesOfFigures()
        {
            foreach (string s in FigureTypes.GetNames(typeof(FigureTypes)))
            {
                ConsoleHelper.Write($"-{s}");
            }
        }

        private static void GetBaseData(out int x, out int y, out string colour)
        {
            x = ConsoleHelper.ReadValue($"Enter coord x:");

            y = ConsoleHelper.ReadValue($"Enter coord y:");

            colour = ConsoleHelper.ReadString($"Enter colour:");
        }

        private static Line DrawLine()
        {
            int x, y;
            string colour = null;
            GetBaseData(out x, out y, out colour);
            var length = ConsoleHelper.ReadValue($"Enter length:");
            return new Line(length, x, y, colour);
        }

        private static Circle DrawCircle()
        {
            int x, y;
            string colour = null;
            GetBaseData(out x, out y, out colour);
            var radius = ConsoleHelper.ReadValue($"Enter radius:");
            return new Circle(radius, x, y, colour);
        }

        private static Range DrawRange()
        {
            int x, y;
            string colour = null;
            GetBaseData(out x, out y, out colour);
            var radius = ConsoleHelper.ReadValue($"Enter radius:");
            return new Range(radius, x, y, colour);
        }

        private static Ring DrawRing()
        {
            int x, y;
            string colour = null;
            GetBaseData(out x, out y, out colour);
            var radius = ConsoleHelper.ReadValue($"Enter radius:");
            var innerRadius = ConsoleHelper.ReadValue($"Enter inner radius:");
            return new Ring(radius, innerRadius, x, y, colour);
        }

        private static RegularTetragon DrawRegularTetragon()
        {
            int x, y;
            string colour = null;
            GetBaseData(out x, out y, out colour);
            var side = ConsoleHelper.ReadValue($"Enter side:");
            return new RegularTetragon(side, x, y, colour);
        }

        private static Rectangle DrawRectangle()
        {
            int x, y;
            string colour = null;
            GetBaseData(out x, out y, out colour);
            var side = ConsoleHelper.ReadValue($"Enter the first side:");
            var secondSide = ConsoleHelper.ReadValue($"Enter the second side:");
            return new Rectangle(side, secondSide, x, y, colour);
        }

        private static Triangle DrawTriangle()
        {
            int x, y;
            string colour = null;
            GetBaseData(out x, out y, out colour);
            var angle = ConsoleHelper.ReadValue($"Enter the angle:");
            var firstCathetus = ConsoleHelper.ReadValue($"Enter the first cathetus:");
            var secondCathetus = ConsoleHelper.ReadValue($"Enter the second cathetus:");
            return new Triangle(angle, firstCathetus, secondCathetus, x, y, colour);
        }

        private enum FigureTypes
        {
            Line,
            Circle,
            Range,
            Ring,
            Triangle,
            RegularTetragon,
            Rectangle
        }
    }
}
