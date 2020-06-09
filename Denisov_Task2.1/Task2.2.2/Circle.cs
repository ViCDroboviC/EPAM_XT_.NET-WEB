using General;
using System;

namespace Task2._2._2
{
    public class Circle : AbstractGeometry, IPrintable
    {
        protected int radius;
        protected double circleLength
        {
            get
            {
                return 2 * Math.PI * radius;
            }
        }

        public Circle (int inputRadius, int x, int y, string inputColour) : base(x, y, inputColour)
        {
            this.radius = inputRadius;
        }

        public override void Print()
        {
            base.Print();
            ConsoleHelper.Write($"Окружность радиуса: {radius}, и центром в точке с координатами [{centre[0]},{centre[1]}]");
        }
    }
}
