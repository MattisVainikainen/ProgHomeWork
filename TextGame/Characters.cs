using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Characters
    {
        private string characterName;
        private string characterRace;
        private int damage;
        private int health;


        public Characters(string _characterName, string _characterRace, int _damage, int _health)
        {
            characterName = _characterName;
            characterRace = _characterRace;
            damage = _damage;
            health = _health;
            GetHealth();
        }
        public string CharacterName
        {
            get { return characterName; }
            set
            {
                characterName = value;
            }
        }

        public string CharacterRace
        {
            get { return characterRace; }
            set
            {
                characterRace = value;
            }
        }

        public int Damage
        {
            get { return damage; }
            set
            {
                damage = value;
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                health = value;       
            }
        }

        public int GetHealth()
        {
            if(health <= 50)
            {
                AddDamage(200);
                Console.WriteLine($"{CharacterName} is very weak with {Health} points.");
                Console.WriteLine($"WeaponDamage: {Damage}");
                Console.WriteLine();
            }
            else if(health > 51 && health < 400)
            {
                AddDamage(100);
                Console.WriteLine($"{CharacterName} is normal with {Health} points.");
                Console.WriteLine($"WeaponDamage: {Damage}");
                Console.WriteLine();
            }
            else if( health > 800)
            {
                AddDamage(10);
                Console.WriteLine($"{CharacterName} is a SUPERTANK with {Health} points.");
                Console.WriteLine($"WeaponDamage: {Damage}");
                Console.WriteLine();
            }
            else
            {
                AddDamage(150);
                Console.WriteLine($"{CharacterName} is Strong with {Health} points.");
                Console.WriteLine($"WeaponDamage: {Damage}");
                Console.WriteLine();
            }
            return health;
        }

        public int AddDamage(int amount)
        {
            damage += amount;
            return damage;
        }
    }
}
