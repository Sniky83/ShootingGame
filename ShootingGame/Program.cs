using Core.Player;
using Core.Weapon;
using Core.Weapon.AssaultRifles;
using Core.Weapon.Pistols;

Player Sniky = new Player(username: "Sniky", cammo: CammoEnum.Arctic, primaryWeapon: new AK47(), new USP45());
Player Corwin = new Player(username: "Corwin", cammo: CammoEnum.Desert, primaryWeapon: new M16(), new DesertEagle());

//This generates an Exception
//Corwin.Shoot(Corwin);

while (true)
{
    Thread.Sleep(2000);

    Sniky.Shoot(Corwin);

    if(!Corwin.IsAlive)
        break;

    Thread.Sleep(2000);

    Corwin.Shoot(Sniky);

    if (!Sniky.IsAlive)
        break;
}

Console.ResetColor();

Console.WriteLine("Press any key to close the game.");

Console.ReadKey();