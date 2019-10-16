using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameWizard
{
    class Enemy
    {
        int health;
        int cashReward;
        int expReward;
        int damage;
        string name;


        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }

        public int CashReward
        {
            get { return cashReward; }
            set
            {
                cashReward = value;
            }
        }

        public int ExpReward
        {
            get { return expReward; }
            set
            {
                expReward = value;
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

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public virtual void SpecialHit()
        {

        }

        public Enemy(int _health, int _cashReward, int _expReward, int _damage, string _name)
        {
            health = _health;
            cashReward = _cashReward;
            expReward = _expReward;
            damage = _damage;
            name = _name;
        }
    }
}
