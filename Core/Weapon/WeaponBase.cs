using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon
{
    public abstract class WeaponBase : IWeapon
    {
        public string Name { get; set; }
        public double Recoil { get; set; }
        public int Weight { get; set; }
        public int Damage { get; set; }
        public int Ammo { get; set; }
        public bool IsPistol { get; set; }

        public WeaponBase(string name, double recoil, int weight, int damage, int ammo, bool isPistol)
        {
            Name = name;
            Recoil = recoil;
            Weight = weight;
            Damage = damage;
            Ammo = ammo;
            IsPistol = isPistol;
        }
    }
}
