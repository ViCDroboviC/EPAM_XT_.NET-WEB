using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    internal class Monster : AbstractMooveableObject, IObject, IMooveable
    {
        private int damage;
        public Monster(int x, int y) : base(x, y)
        {
            damage = 50;
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
                    case 1:
                        targetCell = world.CheckCell(world, coordinates[1]++, coordinates[2]);
                        break;
                    case 2:
                        targetCell = world.CheckCell(world, coordinates[1]--, coordinates[2]);
                        break;
                    case 3:
                        targetCell = world.CheckCell(world, coordinates[1], coordinates[2]++);
                        break;
                    case 4:
                        targetCell = world.CheckCell(world, coordinates[1], coordinates[2]--);
                        break;
                }
                if (targetCell is null)
                {
                    coordinates[1] = targetCell.coordinates[1];
                    coordinates[2] = targetCell.coordinates[2];
                    mooveComplete = true;
                }
                else if (targetCell is Player)
                {
                    Interact(targetCell as Player);
                    mooveComplete = true;
                }
            }
            while (mooveComplete == false);                
        }

        protected override int ChooseDirection()
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }

        private void Interact (Player player)
        {
            player.health = -damage;
        }
    }
}
