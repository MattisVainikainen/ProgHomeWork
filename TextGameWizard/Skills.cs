using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameWizard
{
    class Skills
    {
        public virtual void SpecialSkill()
        {
            Random rnd = new Random();
            int damageSpecialHIT = rnd.Next(10, 20);
        }

        public void NormalHit()
        {
            Random rnd = new Random();
            int damageNormalHIT = rnd.Next(1, 4);
        }
    }
}
