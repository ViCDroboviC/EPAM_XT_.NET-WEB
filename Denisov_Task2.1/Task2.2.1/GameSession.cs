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
        private GameWorld world;

        public GameSession(GameWorld newWorld)
        {
            this.world = newWorld;
            this.score = 0;
            this.stepsNumber = 0;
            this.gameOver = false;
        }

        public void Start()
        {
            do
            {
                Step.NextStep(ref world, ref score, ref gameOver);
                stepsNumber++;
            }
            while (!gameOver);
        }
    }
}
