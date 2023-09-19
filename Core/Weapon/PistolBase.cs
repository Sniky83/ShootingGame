using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon
{
    public class PistolBase : WeaponBase
    {
        public PistolBase(string name, double recoil, int weight, int damage, int ammo = 8, bool isPistol = true) : base(name, recoil, weight, damage, ammo, isPistol) { }
    }
}
