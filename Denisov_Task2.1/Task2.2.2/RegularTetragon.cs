using General;
using System;

namespace Task2._2._2
{
    class RegularTetragon : AbstractGeometry, IPrintable
    {
        protected int side;

        protected virtual double square
        {
            get
            {
                return Math.Pow(side, 2);
            }
        }

        public RegularTetragon (int inputSide, int x, int y, string inputColour) : base(x, y, inputColour)
        {
            this.side = inputSide;
        }

        public override void Print()
        {
            base.Print();
            ConsoleHelper.Write($"Квадрат со стороной: {side}, площадью {square} и центром в точке с координатами [{centre[0]},{centre[1]}]");
        }
    }
}
