using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    internal class Obstacle : AbstractGameObject, IObject
    {
        internal Obstacle(int x, int y) : base(x, y) { }
    }
}
