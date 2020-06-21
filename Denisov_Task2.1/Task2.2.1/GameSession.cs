using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2._1
{
    public class GameSession
    {
        private bool gameOver;
        private int stepsNumber;
        private int score;
        private int numberOfBonuses;
        private GameWorld world;

        public GameSession(GameWorld newWorld, int numberOfBonuses)
        {
            this.world = newWorld;
            this.score = 0;
            this.stepsNumber = 0;
            this.gameOver = false;
            this.numberOfBonuses = numberOfBonuses;
        }

        public void Start()
        {
            do
            {
                Step.NextStep(world, ref score);
                stepsNumber++;
            }
            while (!gameOver);
        }

        private bool CheckGameIsOverConditions()
        {
            var player = (world.Objects).Where(obj => obj is Player);
            if (score == numberOfBonuses * 100 || (player as Player).health == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
