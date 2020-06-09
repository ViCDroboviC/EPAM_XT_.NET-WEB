using General;
using System;

namespace Task2._2._2
{
    public class Range : Circle, IPrintable
    {
        protected virtual double square
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public Range (int inputRadius, int x, int y, string inputColour) : base(inputRadius, x, y, inputColour)
        {
        }

        public override void Print()
        {
            base.Print();
            ConsoleHelper.Write($"Круг радиуса: {radius}, площадью {square} и центром в точке с координатами [{centre[0]},{centre[1]}]");
        }
    }
}
