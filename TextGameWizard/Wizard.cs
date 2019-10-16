using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameWizard
{
    class Wizard: Enemy
    {
        public Wizard(int _health, int _cashReward, int _expReward, int _damage, string _name):base(_health, _cashReward, _expReward, _damage, _name)
        {
            
        }

        public static void CreateWizard()
        {
            Random rnd = new Random();
            int randomDamage = rnd.Next(1, 5);
            int randomExperience = rnd.Next(6, 11);
            int randomHealth = rnd.Next(35, 60);
            int randomNumber = rnd.Next(1, 4);
            

            switch(randomNumber)
            {
                case 1:
                    Wizard wiZ = new Wizard(randomHealth, 40, randomExperience, randomDamage, "Dark Wiz");
                    Console.WriteLine($"{wiZ.Name} got {wiZ.Health} health. Killing it will give you {wiZ.ExpReward} experience points and {wiZ.CashReward} gold!");
                    break;

                case 2:
                    Wizard Coolkid = new Wizard(randomHealth, 20, randomExperience, randomDamage, "Little Sancho");
                    Console.WriteLine($"{Coolkid.Name} got {Coolkid.Health} health. Killing it will give you {Coolkid.ExpReward} experience points and {Coolkid.CashReward} gold!");
                    break;

                case 3:
                    int randomHealths = rnd.Next(200, 350);
                    Wizard DarkWiz = new Wizard(randomHealths, 70, randomExperience, randomDamage, "The dark force");
                    Console.WriteLine($"{DarkWiz.Name} got {DarkWiz.Health} health. Killing it will give you {DarkWiz.ExpReward} experience points and {DarkWiz.CashReward} gold!");
                    break;
            }
            

        }

        public override void SpecialHit()
        {
           
        }
    }
}
