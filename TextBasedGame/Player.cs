using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Player
    {
        static int health;
        static int cash;
        static string playerName;
        static int experiencePoints;


        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }

        public int Cash
        {
            get { return cash; }
            set
            {
                cash = value;
            }
        }

        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set
            {
                experiencePoints = value;
            }
        }
        
        public string Name
        {
            get
            {
                return playerName;
            }
        }

        public void NormalHit(Enemy enemy)
        {
            Random rndDamage = new Random();

            int playerDamage = rndDamage.Next(1, 10);

            if (playerDamage > 7)
            {
                Console.WriteLine("Critical hit!");
                Console.WriteLine($"You did {playerDamage} damage!");
            }
            else
            {
                Console.WriteLine($"You did {playerDamage} damage!");
            }

            enemy.Health -= playerDamage;
        }

        public void ReduceCash(Player p, int amount)
        {
            p.Cash -= amount;
        }

        public Player(int _health, int _cash, int _exp)
        {
            health = _health;
            cash = _cash;
            experiencePoints = _exp;
        }
        public static void ChooseName()
        {
            Console.WriteLine("Choose your name: ");
            playerName = Console.ReadLine();  
        }

        public static void ShowStatus()
        {
            Console.WriteLine($"Name: {playerName} Health: {health}, cash: {cash}, experiencePoints: {experiencePoints}");
        }
    }
}
