using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    abstract class Health
    {
        public int HealthPoints { get; set; }
        public static float globalDmgMod;
        public float dmgMod;
        public abstract void DoDamage(int dmg);
    }
}
