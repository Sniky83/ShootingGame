using Core.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Player
{
    internal interface IPlayer
    {
        public string Username { get; set; }
        public CammoEnum Cammo { get; set; }
        public double VelocityPrimaryWeapon { get; set; }
        public double VelocitySecondaryWeapon { get; set; }
        public WeaponBase PrimaryWeapon { get; set; }
        public WeaponBase SecondaryWeapon { get; set; }
        public int Health { get; set; }
        public bool IsAlive { get; set; }
        public bool IsFirstCall { get; set; }
        public double CalculateVelocity(int weaponWeight);
        public void ApplyCammo(CammoEnum cammo);
        public void CheckHealth(Player player);
        public void DealDamage(Player opponent);
        public void Shoot(Player opponent);
    }
}
