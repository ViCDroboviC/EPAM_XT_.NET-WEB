using General;
using System;

namespace Task2._2._2
{
    class Ring : Range, IPrintable
    {
        protected int innerRadius;
        protected override double square
        {
            get
            {
                return (Math.PI * Math.Pow(radius, 2))-(Math.PI * Math.Pow(innerRadius, 2));
            }
        }

        public Ring (int inputRadius, int inputInnerRadius, int x, int y, string inputColour) : base(inputRadius, x, y, inputColour)
        {
            this.innerRadius = inputInnerRadius;
        }

        public override void Print()
        {
            base.Print();
            ConsoleHelper.Write($"Кольцо радиуса: {radius}, внутренним радиусом: {innerRadius} площадью {square}" +
                $" и центром в точке с координатами [{centre[0]},{centre[1]}]");
        }
    }
}
