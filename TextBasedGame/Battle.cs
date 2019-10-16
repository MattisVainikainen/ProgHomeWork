using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Battle
    {
        public static int TakeDamage(Player player, int dmg)
        {
            return player.Health -= dmg;
        }

        public static int RewardCash(Player player, int cash)
        {
            return player.Cash += cash;
        }

        public static int RewardExp(Player player, int exp)
        {
            return player.ExperiencePoints += exp;
        }

        public static void Fight(Player p)
        {
            Enemy enemy = new Enemy();

            enemy = Enemy.RandomEnemy(enemy);


            do
            {
                Random rnd = new Random();
                int chance = rnd.Next(1,10);

                p.NormalHit(enemy);
                if (enemy.Health <= 0)
                {
                    enemy.Health = 0;
                    Console.WriteLine($"{enemy.Name} is dead");
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine();
                    RewardCash(p, 30);
                    p.ExperiencePoints += 10;
                    break;
                }
                    Console.WriteLine($"{enemy.Name} health: {enemy.Health}");
                    Console.WriteLine();

                System.Threading.Thread.Sleep(1000);

                switch (chance)
                {
                    case 1:
                        enemy.SpecialHit(p, enemy);
                        if (p.Health <= 0)
                        {
                            p.Health = 0;
                            Console.WriteLine("Dead");
                            Console.WriteLine($"{enemy.Name} took some of your money...");
                            p.Cash -= 40;
                            break;
                        }
                        Console.WriteLine($"Player health: {p.Health}");
                        Console.WriteLine();
                        break;

                    default:
                        enemy.NormalHit(p, enemy);
                        if (p.Health <= 0)
                        {
                            p.Health = 0;
                            Console.WriteLine("Dead");
                            Console.WriteLine($"{enemy.Name} took some of your money...");
                            p.Cash -= 40;
                            break;
                        }
                        Console.WriteLine($"Player health: {p.Health}");
                        Console.WriteLine();
                        break;
                }

                System.Threading.Thread.Sleep(1000);

            } while (enemy.Health > 0 && p.Health > 0);
            Console.ReadKey();
        }

        //public virtual int SpecialHit(int sHit)
        //{
        //    Random rnd = new Random();
        //    int chance = rnd.Next(1, 7);

        //    if (chance == 1)
        //    {
        //        sHit += 10;
        //    }
        //    return sHit;
        //}

        public static void Heal(Player p)
        {
            Console.Clear();
            Random rndHeal = new Random();
            int heal = rndHeal.Next(30, 50);

            Player.ShowStatus();

            Console.WriteLine($"Greetings {p.Name}!");
            Console.WriteLine($"Your health is {p.Health}...");

            string choice;

            do
            {
                Console.WriteLine("Would you like me to heal you for 40 pieces of gold?");
                Console.Write("Y or N: ");

                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "Y":
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Healing");
                            System.Threading.Thread.Sleep(1500);
                        }
                        p.Health += heal;
                        p.ReduceCash(p, 40);
                        break;

                    case "N":
                        Console.WriteLine($"Safe travels {p.Name}!");
                        break;

                    default:
                        Console.WriteLine("You speak a tongue I do not understand...");
                        break;
                } 
            } while (choice != "Y" && choice != "N");
        }
    }
}
