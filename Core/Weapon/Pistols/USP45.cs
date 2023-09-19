using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon.Pistols
{
    public class USP45 : PistolBase
    {
        public USP45(string name = "USP45", double recoil = 1.2F, int weight = 838, int damage = 22) : base(name, recoil, weight, damage) { }
    }
}
