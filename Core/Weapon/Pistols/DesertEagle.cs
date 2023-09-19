using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon.Pistols
{
    public class DesertEagle : PistolBase
    {
        public DesertEagle(string name = "Desert Eagle", double recoil = 1.6F, int weight = 906, int damage = 21, int ammo = 6) : base(name, recoil, weight, damage, ammo) {}
    }
}
