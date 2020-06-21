using System;

namespace Task2._2._1
{
    public class GameWorldGenerator
    {
        internal static GameWorld GenerateNewWorld(int obstaclesNumber, int bonusesNumber, int monstersNumber)
        {
            GameWorld newGameWorld;

            Map newMap = new Map(30, 20);
            newGameWorld = new GameWorld(newMap);



            GenerateObstacles(ref newGameWorld, obstaclesNumber);

            GenerateBonuses(ref newGameWorld, bonusesNumber);

            GeneratePlayer(ref newGameWorld);

            GenerateMonsters(ref newGameWorld, monstersNumber);
           
            PlaceObjects(ref newGameWorld);

            return newGameWorld;
        }
        private static void GenerateObstacles(ref GameWorld world, int obstacles)
        {
            Random rnd = new Random();
            for (int i = 0; i <= obstacles; i++)
            {
                bool freeCoords = false;
                int x;
                int y;
                do
                {                   
                    x = rnd.Next(1, world.width - 1);
                    y = rnd.Next(1, world.width - 1);

                    freeCoords = CoordsIsFree(ref world, x, y);

                    if (freeCoords)
                    {
                        world.Objects.Add(new Obstacle(x, y));
                    }
                }
                while (!freeCoords);
            }
        }
        private static void GenerateBonuses(ref GameWorld world, int bonuses)
        {
            Random rnd = new Random();
            for (int i = 0; i <= bonuses; i++)
            {
                bool freeCoords = false;
                int x;
                int y;
                do
                {
                    x = rnd.Next(1, world.width - 1);
                    y = rnd.Next(1, world.width - 1);

                    freeCoords = CoordsIsFree(ref world, x, y);

                    if (freeCoords)
                    {
                        world.Objects.Add(new Bonus(x, y));
                    }
                }
                while (!freeCoords);
            }
        }
        private static void GenerateMonsters(ref GameWorld world, int monsters)
        {
            Random rnd = new Random();
            for (int i = 0; i <= monsters; i++)
            {
                bool freeCoords = false;
                int x;
                int y;
                do
                {
                    x = rnd.Next(1, world.width - 1);
                    y = rnd.Next(1, world.width - 1);

                    freeCoords = CoordsIsFree(ref world, x, y);

                    if (freeCoords)
                    {
                        world.Objects.Add(new Monster(x, y));
                    }
                }
                while (!freeCoords);
            }
        }
        private static void GeneratePlayer(ref GameWorld world)
        {
            Random rnd = new Random();            
            bool freeCoords = false;
            int x;
            int y;

            do
            {
                x = rnd.Next(1, world.width - 1);
                y = rnd.Next(1, world.width - 1);

                freeCoords = CoordsIsFree(ref world, x, y);

                if (freeCoords)
                {
                    world.Objects.Add(new Player(x, y));
                }
            }
            while (!freeCoords);            
        }
        private static void PlaceObjects(ref GameWorld world)
        {
            foreach (AbstractGameObject obj in world.Objects)
            {
                world.cells[obj.coordinates[1], obj.coordinates[2]] = obj;
            }                   
        }

        private static void PlaceObstacles (ref GameWorld world, int obstacles)
        {
            Random rnd = new Random();
            for (int i = 0; i <= obstacles; i++)
            {
                int x;
                int y;
                do
                {
                    x = rnd.Next(1, world.width - 1);
                    y = rnd.Next(1, world.width - 1);
                    if (world.cells[x, y] == null)
                    {
                        world.cells[x, y] = new Obstacle(x, y);
                    }
                }
                while (world.cells[x, y] != null);
            }
        }
        private static void PlaceBonuses(ref GameWorld world, int bonuses)
        {
            Random rnd = new Random();
            for (int i = 0; i <= bonuses; i++)
            {
                int x;
                int y;
                do
                {
                    x = rnd.Next(1, world.width - 1);
                    y = rnd.Next(1, world.width - 1);
                    if (world.cells[x, y] == null)
                    {
                        world.cells[x, y] = new Bonus(x, y);
                    }
                }
                while (world.cells[x, y] != null);
            }
        }
        private static void PlaceMonsters(ref GameWorld world, int monsters)
        {
            Random rnd = new Random();
            for (int i = 0; i <= monsters; i++)
            {
                int x;
                int y;
                do
                {
                    x = rnd.Next(1, world.width - 1);
                    y = rnd.Next(1, world.width - 1);
                    if (world.cells[x, y] == null)
                    {
                        world.cells[x, y] = new Monster(x, y);
                    }
                }
                while (world.cells[x, y] != null);
            }
        }
        private static void PlacePlayer(ref GameWorld world)
        {
            int x;
            int y;

            Random rnd = new Random();

            do
            {
                x = rnd.Next(1, world.width - 1);
                y = rnd.Next(1, world.width - 1);

                if (world.cells[x, y] == null)
                {
                    world.cells[x, y] = new Player(x, y);
                }

            }
            while (world.cells[x, y] != null);
            
        }

        private static bool CoordsIsFree(ref GameWorld world, int x, int y)
        {
            foreach (AbstractGameObject obj in world.Objects)
            {
                if (obj.coordinates == new int[2] { x, y })
                {
                    return false;
                }
            }
            return true;
        }
    }
}
