using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Weapon.AssaultRifles
{
    public class ACR : AssaultRiffleBase
    {
        public ACR(string name = "ACR", double recoil = 1.2F, int weight = 2254, int damage = 31) : base(name, recoil, weight, damage){}
    }
}
