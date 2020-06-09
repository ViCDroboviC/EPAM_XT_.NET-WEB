using General;

namespace Task2._2._2
{
    public class Line : AbstractGeometry, IPrintable
    {
        private int length;

        public Line (int inputLength, int x, int y, string inputColour) : base(x, y, inputColour)
        {
            this.length = inputLength;
        }

        public override void Print() 
        {
            base.Print();
            ConsoleHelper.Write($"Отрезок длинной: {length}, и центром в точке с координатами [{centre[0]},{centre[1]}]");
        }
    }
}
