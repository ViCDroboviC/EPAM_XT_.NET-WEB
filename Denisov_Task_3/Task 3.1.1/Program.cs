using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_3._1._2;

namespace Task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Greetings!");
            Game newGame = new Game();
            newGame.GameStart();
        }
    }
}
