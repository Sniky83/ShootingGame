using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon.AssaultRifles
{
    public class AK47 : AssaultRiffleBase
    {
        public AK47(string name = "AK47", double recoil = 1.4F, int weight = 2580, int damage = 32) : base(name, recoil, weight, damage) { }
    }
}
