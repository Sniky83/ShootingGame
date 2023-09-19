using Core.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Player
{
    public class Player : IPlayer
    {
        public string Username { get; set; }
        public CammoEnum Cammo { get; set; }
        public double VelocityPrimaryWeapon { get; set; }
        public double VelocitySecondaryWeapon { get; set; }
        public WeaponBase PrimaryWeapon { get; set; }
        public WeaponBase SecondaryWeapon { get; set; }
        public int Health { get; set; } = PlayerConst.BaseHealth;
        public bool IsAlive { get; set; } = true;

        public Player(string username, CammoEnum cammo, WeaponBase primaryWeapon, WeaponBase secondaryWeapon)
        {
            Username = username;
            Cammo = cammo;
            PrimaryWeapon = primaryWeapon;
            SecondaryWeapon = secondaryWeapon;
            VelocityPrimaryWeapon = CalculateVelocity(primaryWeapon.Weight);
            VelocitySecondaryWeapon = CalculateVelocity(secondaryWeapon.Weight);

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Player : {username}\nCammo Chosen : {Enum.GetName(typeof(CammoEnum), cammo)}\nPrimary Weapon : {primaryWeapon.Name}\nSecondary Weapon : {secondaryWeapon.Name}\nRunning at : {VelocityPrimaryWeapon} km with {primaryWeapon.Name}\nRunning at : {VelocitySecondaryWeapon} km with {secondaryWeapon.Name}\nAmmo of Primary Weapon : {primaryWeapon.Ammo}\nAmmo of Secondary Weapon : {secondaryWeapon.Ammo}\nDamage of Primary Weapon : {primaryWeapon.Damage}\nDamage of Secondary Weapon : {secondaryWeapon.Damage}\n");
        }

        public double CalculateVelocity(int weaponWeight)
        {
            double theoricSpeed = (double)weaponWeight / 200;
            double finalSpeed = PlayerConst.BaseVelocity - theoricSpeed;
            return finalSpeed;
        }

        public void ApplyCammo(CammoEnum cammo)
        {
            switch (cammo)
            {
                case CammoEnum.Arctic:
                    //Apply arctic cammo to the player
                    break;
                case CammoEnum.Desert:
                    //Apply desert cammo to the player
                    break;
                case CammoEnum.Wood:
                    //Apply wood cammo to the player
                    break;
            }
        }

        public void CheckHealth(Player player)
        {
            if (player.Health <= 0)
            {
                player.IsAlive = false;
                player.Health = 0;

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"{player.Username} is dead !");
            }
            else
            {
                player.IsAlive = true;

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"{player.Username} is still alive with {player.Health} HP.");
            }
        }

        public void DealDamage(Player opponent)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Random random = new Random();
            bool isShotMissed = random.Next(2) == 1;
            bool isPrimaryWeapon = random.Next(2) == 1;

            if (isPrimaryWeapon)
            {
                Console.WriteLine($"{this.Username} is shooting {opponent.Username} with his primary weapon.");
            }
            else
            {
                Console.WriteLine($"{this.Username} is shooting {opponent.Username} with his secondary weapon.");
            }

            Console.ForegroundColor = ConsoleColor.Red;

            if (!isShotMissed)
            {
                if (isPrimaryWeapon)
                {
                    Console.WriteLine($"{opponent.Username} took {this.PrimaryWeapon.Damage} damages.");

                    opponent.Health = (opponent.Health - this.PrimaryWeapon.Damage);
                }
                else
                {
                    Console.WriteLine($"{opponent.Username} took {this.SecondaryWeapon.Damage} damages.");

                    opponent.Health = (opponent.Health - this.SecondaryWeapon.Damage);
                }
            }
            else
            {
                Console.WriteLine("Shot missed :(");
            }
        }

        public void Shoot(Player opponent)
        {
            //Don't allow to shoot if the player is not alive
            if(!this.IsAlive)
            {
                return;
            }

            //Don't allow to call shooting func if the opponnent is himself
            if(this == opponent)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("Please don't suicide and try to shoot someone else.");
            }

            DealDamage(opponent);

            CheckHealth(opponent);

            Console.WriteLine();
        }
    }
}
