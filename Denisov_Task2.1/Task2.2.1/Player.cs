using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    internal class Player : AbstractMooveableObject, IObject, IMooveable
    {
        internal int health;
        internal int score;
        public Player (int x, int y) : base(x, y)
        {
            health = 100;
        }

        public override void Moove(GameWorld world, ref int score)
        {
            bool mooveComplete = false;
            int heading = ChooseDirection();
            AbstractGameObject targetCell = null;
            do
            {


                switch (heading)
                {
                    case 2:
                        targetCell = world.CheckCell(world, coordinates[1], coordinates[2]--);
                        break;
                    case 4:
                        targetCell = world.CheckCell(world, coordinates[1]--, coordinates[2]);
                        break;
                    case 6:
                        targetCell = world.CheckCell(world, coordinates[1]++, coordinates[2]);
                        break;
                    case 8:
                        targetCell = world.CheckCell(world, coordinates[1], coordinates[2]++);
                        break;
                    default:
                        break;
                }
                if (targetCell is null)
                {
                    coordinates[1] = targetCell.coordinates[1];
                    coordinates[2] = targetCell.coordinates[2];
                    mooveComplete = true;
                }
                else if (targetCell is Bonus)
                {
                    Interact(targetCell as Bonus, world, ref score);
                    coordinates[1] = targetCell.coordinates[1];
                    coordinates[2] = targetCell.coordinates[2];
                    mooveComplete = true;
                }
            }
            while (!mooveComplete);
        }

        protected override int ChooseDirection()
        {
            int heading;
            do
            {
                heading = ConsoleHelper.ReadValue($"Choose direction: 2-down, 4-left, 6-right, 8-up");
                if (heading != 2 || heading != 4 || heading != 6 || heading != 8)
                {
                    ConsoleHelper.Write($"You entered the wrong value");
                }
            }
            while (heading != 2 || heading != 4 || heading != 6 || heading != 8);
            return heading;
        }

        private void Interact(Bonus bonus, GameWorld world, ref int score)
        {
            score = +bonus.scoreBonus;
            world.Objects.Remove(bonus);
        }
    }
}
