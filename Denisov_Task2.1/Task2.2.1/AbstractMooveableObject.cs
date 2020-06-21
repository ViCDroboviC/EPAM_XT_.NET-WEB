using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    internal abstract class AbstractMooveableObject : AbstractGameObject
    {
        public AbstractMooveableObject(int x, int y) : base(x, y) { }

        public abstract void Moove(GameWorld world);

        protected abstract int ChooseDirection();
    }
}
