using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon.Pistols
{
    public class Colt45 : PistolBase
    {
        public Colt45(string name = "DesertEagle", double recoil = 1.7F, int weight = 744, int damage = 20) : base(name, recoil, weight, damage) { }
    }
}
