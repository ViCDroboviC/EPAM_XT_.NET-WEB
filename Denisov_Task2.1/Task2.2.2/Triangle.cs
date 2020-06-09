using General;
using System;

namespace Task2._2._2
{
    class Triangle : AbstractGeometry, IPrintable
    {
        protected int angle;

        protected int[] topCoordinates;

        protected int firstCathetus;

        protected int secondCathetus;

        protected double square
        {
            get
            {
                return (firstCathetus * secondCathetus * Math.Sin(angle)) / 2;
            }
        }

        public Triangle (int inputAngle, int inputCathetus1, int inputCathetus2, int x, int y, string inputColour) : base(inputColour)
        {
            this.angle = inputAngle;
            this.topCoordinates = new int[2] { x, y };
            this.firstCathetus = inputCathetus1;
            this.secondCathetus = inputCathetus2;
        }

        public override void Print()
        {
            base.Print();
            ConsoleHelper.Write($"Треуголник с катетами: {firstCathetus} и {secondCathetus}, углом меду ними в {angle} градусов  с координатами [{centre[0]},{centre[1]}]");
        }
    }
}
