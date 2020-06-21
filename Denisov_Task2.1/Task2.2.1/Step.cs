using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    static public class Step
    {
        public static void NextStep(ref GameWorld world, ref int score, ref bool gameOver)
        {
            MooveObjects(ref world);
        }

        private static void MooveObjects(ref GameWorld world)
        {
            var objects = (world.Objects).Where(obj => obj is IMooveable);

            foreach (IMooveable obj in objects)
            {
                obj.Moove(world);
            }
            //foreach (AbstractGameObject obj in world.Objects)
            //{
            //    if (obj is IMooveable)
            //    {
            //        (obj as IMooveable).Moove();
            //    }
            //}
        }
    }
}
