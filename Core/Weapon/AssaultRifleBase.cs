using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon
{
    public abstract class AssaultRiffleBase : WeaponBase
    {
        public AssaultRiffleBase(string name, double recoil, int weight, int damage, int ammo = 30, bool isPistol = false) : base(name, recoil, weight, damage, ammo, isPistol) { }
    }
}
