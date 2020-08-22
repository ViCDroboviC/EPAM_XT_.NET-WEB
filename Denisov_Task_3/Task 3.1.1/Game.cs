using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3._1._2;

namespace Task_3._1._1
{
    public class Game
    {
        private int currentPosition;
        private List<Player> players;
        private int knockoutPeriod;

        public Game()
        {
            currentPosition = -1;
            players = new List<Player>();
            int numberOfPlayers = ConsoleHelper.ReadValue("Enter the nuber of players:");
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                //Player newPlayer = new Player(i);
                
                players.Add(new Player(i));
            }
            knockoutPeriod = ConsoleHelper.ReadValue("Enter the period of knocking out:");
            if(knockoutPeriod > numberOfPlayers)
            {
                throw new ArgumentOutOfRangeException("knockoutPeriod", "Can not be bigger than nuber of players.");
            }
        }

        public void GameStart()
        {
            do
            {
                NextStep();
                Console.WriteLine($"Press any key to continue...\n");
                Console.ReadKey();
            }
            while (players.Count >= knockoutPeriod);
            ShowWinners();
        }

        private void NextStep()
        {
            if((currentPosition + knockoutPeriod) > players.Count - 1)
            {
                currentPosition = knockoutPeriod - (players.Count - currentPosition);

                Console.WriteLine($"Player number {players[currentPosition].number} leaves the game.\n");

                players.RemoveAt(currentPosition);

                currentPosition--;
            }

            else if((currentPosition + knockoutPeriod) <= players.Count - 1)
            {
                currentPosition = currentPosition + knockoutPeriod;

                Console.WriteLine($"Player number {players[currentPosition].number} leaves the game.\n");

                players.RemoveAt(currentPosition);

                currentPosition--;
            }
            Console.WriteLine($"Players remained:{players.Count}\n");
        }

        private void ShowWinners()
        {
            foreach(Player winner in players)
            {
                Console.WriteLine($"Player number {winner.number} win!");
            }
            Console.ReadKey();
        }
    }
}
