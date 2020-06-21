namespace Task2._2._1
{
    static internal class Start
    {
        public static void StartGame()
        {
            GameWorld newWorld = null;
            switch (ChooseDifficulty())
            {
                case 1:
                    newWorld = GameWorldGenerator.GenerateNewWorld(50, 5, 2);
                    break;
                default:
                    break;
            }

            GameSession newSession = new GameSession(newWorld);
            newSession.Start();
        }       
        private static int ChooseDifficulty()
        {
        return 1;
        }
    }
}

