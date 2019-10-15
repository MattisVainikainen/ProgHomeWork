using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Enemy
    {
        static string name;
        static int health;

        public string Name
        {
            get { return name; }
        }

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }
        public Enemy(string _name, int _health)
        {
            name = _name;
            health = _health;
        }

        public Enemy()
        {

        }
        //public Enemy(string _name, int _health, int armour)
        //{
        //    name = _name;
        //    health = _health;

        //}

        public void SpecialHit(Player player, Enemy enemy)
        {
            int enemyDamage = 30;

            Console.WriteLine("Mighty blow!");
            Console.WriteLine($"{enemy.Name} did {enemyDamage} damage!");

            player.Health -= enemyDamage;
        }

        public void NormalHit(Player player, Enemy enemy)
        {
            Random rndDamage = new Random();

            int enemyDamage = rndDamage.Next(1, 10);

            if (enemyDamage > 7)
            {
                Console.WriteLine("Mighty blow!");
                Console.WriteLine($"{enemy.Name} did {enemyDamage} damage!");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} did {enemyDamage} damage!");
            }
            player.Health -= enemyDamage;
        }

        public static Enemy RandomEnemy(Enemy enemy)
        {
            Random rnd = new Random();
            int chance = rnd.Next(1,4);

            switch (chance)
            {
                case 1:
                    Enemy orc = new Enemy("Orc", 50);
                    enemy = orc;
                    break;

                case 2:
                    Enemy wizard = new Enemy("Wizard", 30);
                    enemy = wizard;
                    break;

                case 3:
                    Enemy demon = new Enemy("Demon", 40);
                    enemy = demon;
                    break;

                //case 4:
                //    Enemy megaDemon = new Enemy("Mega Demon", 60);
                //    break;
            }
            return enemy;
        }

        //public override void Orc()
        //{

        //}
    }
}
