using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon.AssaultRifles
{
    public class M16 : AssaultRiffleBase
    {
        public M16(string name = "M16", double recoil = 1.5F, int weight = 2602, int damage = 30) : base(name, recoil, weight, damage) { }
    }
}
