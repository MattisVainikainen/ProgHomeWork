using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameWizard
{
    class Player
    {
        string name;
        int health;      
        int damage;
        int experiencePoints;
        int cash;

        public Player (string _name, int _health, int _damage, int _expPoints, int _cash)
        {
            name = _name;
            health = _health;
            damage = _damage;
            experiencePoints = _expPoints;
            cash = _cash;
            
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
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

        public int Damage
        {
            get { return damage; }
            set
            {
                damage = value;
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
            
        public int Cash
        {
            get { return cash; }
            set
            {
                cash = value;
            }
        }
    }
}
