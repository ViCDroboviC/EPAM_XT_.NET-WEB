using General;
using System;

namespace Task2._2._2
{
    public abstract class AbstractGeometry : IPrintable
    {
        protected int[] centre;

        protected GeometryColours colour;

        protected AbstractGeometry(int x, int y, string inputColour)
        {
            this.centre = new int[2] {x, y};
            this.colour = (GeometryColours)Enum.Parse(typeof(GeometryColours), inputColour);
        }

        protected AbstractGeometry(string inputColour)
        {
            this.colour = (GeometryColours)Enum.Parse(typeof(GeometryColours), inputColour);
        }

        public virtual void Print()
        {
            SetColour();
        }

        protected void SetColour()
        {
            switch (colour)
            {
                case GeometryColours.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case GeometryColours.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case GeometryColours.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case GeometryColours.Sky:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case GeometryColours.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case GeometryColours.Violet:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    throw new Exception("Unexpected exception!");

            }

        }


        protected enum GeometryColours
        {
            None,
            Red,
            Yellow,
            Green,
            Sky,
            Blue,
            Violet
        }
    }


}
