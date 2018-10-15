using System;
using System.Collections.Generic;
using System.Text;

namespace fightGame
{
    static class GameEngine
    {
        public static void PlayGame(Hero attacker, Hero defender)
        {
            ConsoleKey ActiveKey = ConsoleKey.A;
            ConsoleKey NonActiveKey = ConsoleKey.M;
            while (true)
                if (Console.ReadKey().Key == ActiveKey)
                {
                    Console.Write("\b");  // backspace character
                    PlayTurn(attacker, defender);
                    if (defender.HearthBeating() != true) break;
                    SwichTurns(ref attacker, ref defender);
                    SwichActiveKey(ref ActiveKey, ref NonActiveKey);
                }
            GameOver(defender.Name, attacker.Name);
        }
        public static void PlayTurn(Hero attacker, Hero defender)
        {
            defender.Defend(attacker.Attack());///////////////////////////////
            Console.WriteLine("{0} has {1} hp left.", defender.Name, defender.GetHealthPoints());
        }
        public static void SwichTurns(ref Hero hero1, ref Hero hero2)
        {
            Hero temp = hero1;
            hero1 = hero2;
            hero2 = temp;
        }
        public static void SwichActiveKey(ref ConsoleKey key1, ref ConsoleKey key2)
        {
            ConsoleKey temp = key1;
            key1 = key2;
            key2 = temp;
        }
        public static void GameOver(string loserName, string winnerName)
        {
            Console.WriteLine("{0} is dead. {1} wins! Press Enter to start a new game.", loserName, winnerName);
            Console.ReadLine();
            Program.Main();
        }















    }
}
