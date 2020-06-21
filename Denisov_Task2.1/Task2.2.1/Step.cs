using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    static public class Step
    {
        public static void NextStep(GameWorld world, ref int score)
        {
            MooveObjects(world, ref score);
        }

        private static void MooveObjects(GameWorld world, ref int score)
        {
            var objects = (world.Objects).Where(obj => obj is IMooveable);

            foreach (IMooveable obj in objects)
            {
                obj.Moove(world, ref score);
            }
        }
    }
}
