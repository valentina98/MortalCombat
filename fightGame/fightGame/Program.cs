using System;

namespace fightGame
{
    class Program
    {
        static Hero DefineHero(string heroType, string heroName)
        {
            Hero theHero;
            switch (heroType)
            {
                case "warrior":
                    Console.WriteLine("You chose a warrior.");
                    theHero = new Warrior(heroName);
                    return theHero;
                case "knight":
                    Console.WriteLine("You chose a knight.");
                    theHero = new Knight(heroName);
                    return theHero;
                case "assasin":
                    Console.WriteLine("You chose an assasin.");
                    theHero = new Assasin(heroName);
                    return theHero;
                case "monk":
                    Console.WriteLine("You chose a monk.");
                    theHero = new Monk(heroName);
                    return theHero;
                case "superhero":
                    Console.WriteLine("You chose a superhero.");
                    theHero = new Monk(heroName);
                    return theHero;
                default:
                    Console.WriteLine("Enter a correct hero type.");
                    return null;
            }
        }

        public static void Main()
        {
           Console.WriteLine("Choose a name of the first hero.");
            string attackerName = Console.ReadLine();
            Console.WriteLine("Choose a kind of the first hero. He can be warrior, knight, assasin, monk or...");
            Hero attacker;
            do
            {
                attacker = DefineHero(Console.ReadLine(), attackerName);
            } while (attacker == null);

            Console.WriteLine("Choose a name of the second hero.");
            string defenderName = Console.ReadLine();
            Console.WriteLine("Choose a kind of the second hero. He can be warrior, knight, assasin, monk or...");
            Hero defender;
            do
            {
                defender = DefineHero(Console.ReadLine(), defenderName);
            } while (attacker == null);

            Console.WriteLine("Press Enter to start the game.");
            Console.ReadLine();
            Console.WriteLine("Use A and M keys to attack.");

            /* Console.WriteLine("New game started!");
            Hero attacker = new Assasin("Altair");
            Hero defender = new Superhero("Batman");*/

            GameEngine.PlayGame(attacker, defender);
            
        }
    }
}
