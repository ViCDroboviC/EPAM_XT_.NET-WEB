using General;

namespace Task2._2._2
{
    class Rectangle : RegularTetragon, IPrintable
    {
        protected int secondSide;

        protected override double square
        {
            get
            {
                return side * secondSide
            }
        }

        public Rectangle (int inputSide, int inputSide2, int x, int y, string inputColour) : base(inputSide, x, y, inputColour)
        {
            this.secondSide = inputSide2;
        }

        public override void Print()
        {
            base.Print();
            ConsoleHelper.Write($"Прямоугольник со сторонами: {side} и {secondSide}, площадью {square} и центром в точке с координатами [{centre[0]},{centre[1]}]");
        }
    }
}
