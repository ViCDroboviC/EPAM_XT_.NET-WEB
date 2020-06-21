using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    internal abstract class AbstractGameObject
    {
        public int[] coordinates;

        public AbstractGameObject (int x, int y)
        {
            this.coordinates = new int[2] { x, y };
        }
    }
}
