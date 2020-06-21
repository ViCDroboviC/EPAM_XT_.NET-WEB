using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    public class GameWorld
    {
        internal int width;
        internal int height;
        internal List<AbstractGameObject> Objects;
        internal AbstractGameObject[,] cells;

        public GameWorld(Map newMap)
        {
            this.width = newMap.width;
            this.height = newMap.height;
            this.cells = new AbstractGameObject[newMap.height, newMap.width];
        }

        internal AbstractGameObject CheckCell(GameWorld world, int x, int y)
        {
            return world.cells[x, y];
        }

        private void ClearWorld(ref IObject[,] cells, ref int width, ref int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    cells[i, j] = null;
                }                
            }
        }

        
    }
}
