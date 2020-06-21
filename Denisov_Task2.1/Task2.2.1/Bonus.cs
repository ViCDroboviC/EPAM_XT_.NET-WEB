using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    class Bonus : AbstractGameObject, IObject
    {
        internal int scoreBonus;
        public Bonus(int x, int y) : base(x, y)
        {
            scoreBonus = 100;
        }
    }
}
